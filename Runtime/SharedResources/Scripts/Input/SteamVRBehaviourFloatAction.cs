namespace Tilia.SDK.SteamVR.Input
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Valve.VR;
    using Zinnia.Action;

    /// <summary>
    /// Listens for the linked single behavior and emits the appropriate action.
    /// </summary>
    public class SteamVRBehaviourFloatAction : FloatAction
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
        /// The SteamVR Single Behavior to link this action to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        SteamVR_Behaviour_Single LinkedSingleBehaviour { get; set; }
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
        /// Registers the listeners against the <see cref="LinkedSingleBehaviour"/>.
        /// </summary>
        protected virtual void RegisterListeners()
        {
            if (LinkedSingleBehaviour == null)
            {
                return;
            }

            LinkedSingleBehaviour.onAxis.AddListener(Listener);
        }

        /// <summary>
        /// Unregisters the listeners against the <see cref="LinkedSingleBehaviour"/>.
        /// </summary>
        protected virtual void UnregisterListeners()
        {
            if (LinkedSingleBehaviour == null)
            {
                return;
            }

            LinkedSingleBehaviour.onAxis.RemoveListener(Listener);
        }

        /// <summary>
        /// Processes the event and re-emits the data via the <see cref="FloatAction"/>.
        /// </summary>
        /// <param name="action">The action raising the event.</param>
        /// <param name="source">The source of the input.</param>
        /// <param name="value">The value of the raised event.</param>
        /// <param name="delta">The delta value between now and the previous raised event.</param>
        protected virtual void Listener(SteamVR_Behaviour_Single action, SteamVR_Input_Sources source, float value, float delta)
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
        /// Called before <see cref="LinkedSingleBehaviour"/> has been changed.
        /// </summary>
        [CalledBeforeChangeOf(nameof(LinkedSingleBehaviour))]
        protected virtual void OnBeforeLinkedSingleBehaviourChange()
        {
            UnregisterListeners();
        }

        /// <summary>
        /// Called after <see cref="LinkedSingleBehaviour"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LinkedSingleBehaviour))]
        protected virtual void OnAfterLinkedSingleBehaviourChange()
        {
            RegisterListeners();
        }
    }
}