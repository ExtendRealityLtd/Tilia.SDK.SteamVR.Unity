namespace Tilia.SDK.SteamVR.Input
{
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Action;
    using Zinnia.Extension;

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

        [Tooltip("The SteamVR Single Behavior to link this action to.")]
        [SerializeField]
        private SteamVR_Behaviour_Single linkedSingleBehaviour;
        /// <summary>
        /// The SteamVR Single Behavior to link this action to.
        /// </summary>
        public SteamVR_Behaviour_Single LinkedSingleBehaviour
        {
            get
            {
                return linkedSingleBehaviour;
            }
            set
            {
                if (this.IsMemberChangeAllowed())
                {
                    OnBeforeLinkedSingleBehaviourChange();
                }
                linkedSingleBehaviour = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterLinkedSingleBehaviourChange();
                }
            }
        }
        [Tooltip("The value to receive from the axis data.")]
        [SerializeField]
        private ValueType axisValue = ValueType.Actual;
        /// <summary>
        /// The value to receive from the axis data.
        /// </summary>
        public ValueType AxisValue
        {
            get
            {
                return axisValue;
            }
            set
            {
                axisValue = value;
            }
        }

        /// <summary>
        /// Clears <see cref="LinkedSingleBehaviour"/>.
        /// </summary>
        public virtual void ClearLinkedSingleBehaviour()
        {
            if (!this.IsValidState())
            {
                return;
            }

            LinkedSingleBehaviour = default;
        }

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
        protected virtual void OnBeforeLinkedSingleBehaviourChange()
        {
            UnregisterListeners();
        }

        /// <summary>
        /// Called after <see cref="LinkedSingleBehaviour"/> has been changed.
        /// </summary>
        protected virtual void OnAfterLinkedSingleBehaviourChange()
        {
            RegisterListeners();
        }
    }
}