namespace Tilia.SDK.SteamVR.Input
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Action;

    /// <summary>
    /// Listens for the linked <see cref="Vector2"/> behavior and emits the appropriate action.
    /// </summary>
    public class SteamVRBehaviourVector2Action : Vector2Action
    {
        /// <summary>
        /// The type of value to use.
        /// </summary>
        public enum ValueType
        {
            /// <summary>
            /// The actual value of the axis.
            /// </summary>
            Actual,
            /// <summary>
            /// The delta value of the axis.
            /// </summary>
            Delta
        }

        /// <summary>
        /// The SteamVR Vector2 Behavior to link this action to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        SteamVR_Behaviour_Vector2 LinkedVector2Behaviour { get; set; }
        /// <summary>
        /// The value to receive from the axis data.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        ValueType AxisValue { get; set; } = ValueType.Actual;

        protected override void OnEnable()
        {
            base.OnEnable();
            RegisterListeners();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            UnregisterListeners();
        }

        /// <summary>
        /// Registers the listeners against the <see cref="LinkedVector2Behaviour"/>.
        /// </summary>
        protected virtual void RegisterListeners()
        {
            if (LinkedVector2Behaviour == null)
            {
                return;
            }

            LinkedVector2Behaviour.onAxis.AddListener(Listener);
        }

        /// <summary>
        /// Unregisters the listeners against the <see cref="LinkedVector2Behaviour"/>.
        /// </summary>
        protected virtual void UnregisterListeners()
        {
            if (LinkedVector2Behaviour == null)
            {
                return;
            }

            LinkedVector2Behaviour.onAxis.RemoveListener(Listener);
        }

        /// <summary>
        /// Processes the event and re-emits the data via the <see cref="Vector2Action"/>.
        /// </summary>
        /// <param name="action">The action raising the event.</param>
        /// <param name="source">The source of the input.</param>
        /// <param name="value">The value of the raised event.</param>
        /// <param name="delta">The delta value between now and the previous raised event.</param>
        protected virtual void Listener(SteamVR_Behaviour_Vector2 action, SteamVR_Input_Sources source, Vector2 value, Vector2 delta)
        {
            switch (AxisValue)
            {
                case ValueType.Actual:
                    Receive(value);
                    break;
                case ValueType.Delta:
                    Receive(delta);
                    break;
            }
        }

        /// <summary>
        /// Called before <see cref="LinkedVector2Behaviour"/> has been changed.
        /// </summary>
        [CalledBeforeChangeOf(nameof(LinkedVector2Behaviour))]
        protected virtual void OnBeforeLinkedVector2BehaviourChange()
        {
            UnregisterListeners();
        }

        /// <summary>
        /// Called after <see cref="LinkedVector2Behaviour"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LinkedVector2Behaviour))]
        protected virtual void OnAfterLinkedVector2BehaviourChange()
        {
            RegisterListeners();
        }
    }
}