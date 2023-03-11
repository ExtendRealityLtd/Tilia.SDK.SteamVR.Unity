namespace Tilia.SDK.SteamVR.Tracking.CameraRig
{
    using UnityEngine;
    using UnityEngine.XR;
    using Valve.VR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    /// <summary>
    /// Provides the description for a SteamVR Input Source element.
    /// TODO: This is a very basic implementation that doesn't use any of the SteamVR library and relies on the Unity libraries. It needs updating to use the SteamVR mechanisms where possible.
    /// </summary>
    public class SteamVRInputSourceRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The SteamVR Input Source.")]
        [SerializeField]
        private SteamVR_Input_Sources inputSource;
        /// <summary>
        /// The SteamVR Input Source.
        /// </summary>
        public SteamVR_Input_Sources InputSource
        {
            get
            {
                return inputSource;
            }
            set
            {
                inputSource = value;
            }
        }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get => ConvertFromInputSource(InputSource); protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }
        /// <inheritdoc/>
        public override bool HasPassThroughCamera { get => false; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets the <see cref="InputSource"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="SteamVR_Input_Sources"/>.</param>
        public virtual void SetInputSourceType(int index)
        {
            InputSource = EnumExtensions.GetByIndex<SteamVR_Input_Sources>(index);
        }

        /// <summary>
        /// Converts an <see cref="SteamVR_Input_Sources"/> type to a Unity <see cref="XRNode"/> type.
        /// </summary>
        /// <param name="inputSource">The input source type to convert.</param>
        /// <returns>The converted type.</returns>
        protected virtual XRNode ConvertFromInputSource(SteamVR_Input_Sources inputSource)
        {
            switch (inputSource)
            {
                case SteamVR_Input_Sources.LeftHand:
                    return XRNode.LeftHand;
                case SteamVR_Input_Sources.RightHand:
                    return XRNode.RightHand;
                case SteamVR_Input_Sources.Gamepad:
                    return XRNode.GameController;
                case SteamVR_Input_Sources.Head:
                    return XRNode.Head;
                case SteamVR_Input_Sources.Camera:
                    return XRNode.CenterEye;
            }

            return XRNode.TrackingReference;
        }
    }
}