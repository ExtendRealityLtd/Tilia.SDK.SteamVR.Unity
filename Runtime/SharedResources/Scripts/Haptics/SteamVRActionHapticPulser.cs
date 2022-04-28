namespace Tilia.SDK.SteamVR.Haptics
{
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="SteamVR_Input_Sources"/> supported haptic device.
    /// </summary>
    public class SteamVRActionHapticPulser : HapticPulser
    {
        [Tooltip("The vibration action to activate.")]
        [SerializeField]
        private SteamVR_Action_Vibration vibrationAction;
        /// <summary>
        /// The vibration action to activate.
        /// </summary>
        public SteamVR_Action_Vibration VibrationAction
        {
            get
            {
                return vibrationAction;
            }
            set
            {
                vibrationAction = value;
            }
        }
        [Tooltip("The controller to pulse.")]
        [SerializeField]
        private SteamVR_Input_Sources controller = SteamVR_Input_Sources.Any;
        /// <summary>
        /// The controller to pulse.
        /// </summary>
        public SteamVR_Input_Sources Controller
        {
            get
            {
                return controller;
            }
            set
            {
                controller = value;
            }
        }
        [Tooltip("The duration to pulse Controller for.")]
        [SerializeField]
        private float duration = 0.1f;
        /// <summary>
        /// The duration to pulse <see cref="Controller"/> for.
        /// </summary>
        public float Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        [Tooltip("The frequency in which the haptic motor will bounce.")]
        [SerializeField]
        [Range(0f, 320f)]
        private float frequency = 1f;
        /// <summary>
        /// The frequency in which the haptic motor will bounce.
        /// </summary>
        public float Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }
        [Tooltip("The duration to wait before starting the pulse.")]
        [SerializeField]
        private float startDelay = 0f;
        /// <summary>
        /// The duration to wait before starting the pulse.
        /// </summary>
        public float StartDelay
        {
            get
            {
                return startDelay;
            }
            set
            {
                startDelay = value;
            }
        }

        /// <inheritdoc />
        protected override void DoBegin()
        {
            if (VibrationAction == null)
            {
                return;
            }

            VibrationAction.Execute(StartDelay, Duration, Frequency, Intensity, Controller);
        }

        /// <inheritdoc />
        protected override void DoCancel()
        {
            VibrationAction.Execute(0f, float.Epsilon, float.Epsilon, float.Epsilon, Controller);
        }
    }
}