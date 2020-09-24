namespace Tilia.SDK.SteamVR.Input
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Valve.VR;
    using Zinnia.Action;

    /// <summary>
    /// Listens for the linked boolean behavior and emits the appropriate action.
    /// </summary>
    public class SteamVRBehaviourBooleanAction : BooleanAction
    {
        /// <summary>
        /// The SteamVR Boolean Behavior to link this action to.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        SteamVR_Behaviour_Boolean LinkedBooleanBehaviour { get; set; }

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
        /// Registers the listeners against the <see cref="LinkedBooleanBehaviour"/>.
        /// </summary>
        protected virtual void RegisterListeners()
        {
            if (LinkedBooleanBehaviour == null)
            {
                return;
            }

            LinkedBooleanBehaviour.onPressDown.AddListener(Listener);
            LinkedBooleanBehaviour.onPressUp.AddListener(Listener);
        }

        /// <summary>
        /// Unregisters the listeners against the <see cref="LinkedBooleanBehaviour"/>.
        /// </summary>
        protected virtual void UnregisterListeners()
        {
            if (LinkedBooleanBehaviour == null)
            {
                return;
            }

            LinkedBooleanBehaviour.onPressDown.RemoveListener(Listener);
            LinkedBooleanBehaviour.onPressUp.RemoveListener(Listener);
        }

        /// <summary>
        /// Processes the event and re-emits the data via the <see cref="BooleanAction"/>.
        /// </summary>
        /// <param name="action">The action raising the event.</param>
        /// <param name="source">The source of the input.</param>
        /// <param name="value">The value of the raised event.</param>
        protected virtual void Listener(SteamVR_Behaviour_Boolean action, SteamVR_Input_Sources source, bool value)
        {
            Receive(value);
        }

        /// <summary>
        /// Called before <see cref="LinkedBooleanBehaviour"/> has been changed.
        /// </summary>
        [CalledBeforeChangeOf(nameof(LinkedBooleanBehaviour))]
        protected virtual void OnBeforeLinkedBooleanBehaviourChange()
        {
            UnregisterListeners();
        }

        /// <summary>
        /// Called after <see cref="LinkedBooleanBehaviour"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LinkedBooleanBehaviour))]
        protected virtual void OnAfterLinkedBooleanBehaviourChange()
        {
            RegisterListeners();
        }
    }
}