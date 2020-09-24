namespace Tilia.SDK.SteamVR.Haptics
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Haptics;

    /// <summary>
    /// Creates a single haptic pulse on a <see cref="SteamVR_Input_Sources"/> supported haptic device.
    /// </summary>
    public class SteamVRActionHapticPulser : HapticPulser
    {
        /// <summary>
        /// The vibration action to activate.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public SteamVR_Action_Vibration VibrationAction { get; set; }
        /// <summary>
        /// The frequency between each pulse.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Range(0f, 1f)]
        public float Frequency { get; set; } = 0.1f;
        /// <summary>
        /// The controller to pulse.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public SteamVR_Input_Sources Controller { get; set; } = SteamVR_Input_Sources.Any;
        /// <summary>
        /// The duration to pulse <see cref="Controller"/> for.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float Duration { get; set; } = 0.1f;
        /// <summary>
        /// The duration to wait before starting the pulse.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float StartDelay { get; set; } = 0f;

        /// <inheritdoc />
        protected override void DoBegin()
        {
            if (VibrationAction == null)
            {
                return;
            }

            VibrationAction.Execute(StartDelay, Duration, Frequency, Intensity, Controller);
            Invoke("DoCancel", Duration);
        }

        /// <inheritdoc />
        protected override void DoCancel()
        {
            CancelInvoke("DoCancel");
            VibrationAction.Execute(0f, 0f, 0f, 0f, Controller);
        }
    }
}