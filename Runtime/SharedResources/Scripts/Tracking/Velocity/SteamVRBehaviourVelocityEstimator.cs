namespace Tilia.SDK.SteamVR.Tracking.Velocity
{
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Extension;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Retrieves the velocity and angular velocity from the specific <see cref="SteamVR_Behaviour_Pose"/>.
    /// </summary>
    public class SteamVRBehaviourVelocityEstimator : VelocityTracker
    {
        [Tooltip("The SteamVR_Behaviour_Pose to track velocity for.")]
        [SerializeField]
        private SteamVR_Behaviour_Pose velocitySource;
        /// <summary>
        /// The <see cref="SteamVR_Behaviour_Pose"/> to track velocity for.
        /// </summary>
        public SteamVR_Behaviour_Pose VelocitySource
        {
            get
            {
                return velocitySource;
            }
            set
            {
                velocitySource = value;
            }
        }
        [Tooltip("An optional GameObject to consider the source relative to when retrieving velocities.")]
        [SerializeField]
        private GameObject relativeTo;
        /// <summary>
        /// An optional <see cref="GameObject"/> to consider the source relative to when retrieving velocities.
        /// </summary>
        public GameObject RelativeTo
        {
            get
            {
                return relativeTo;
            }
            set
            {
                relativeTo = value;
            }
        }

        /// <inheritdoc />
        public override bool IsActive()
        {
            return gameObject.activeInHierarchy && this.CheckIsActiveAndEnabled();
        }

        /// <inheritdoc />
        protected override Vector3 DoGetVelocity()
        {
            if (VelocitySource == null)
            {
                return default;
            }

            return RelativeTo != null ? RelativeTo.transform.rotation * VelocitySource.GetVelocity() : VelocitySource.GetVelocity();
        }

        /// <inheritdoc />
        protected override Vector3 DoGetAngularVelocity()
        {
            if (VelocitySource == null)
            {
                return default;
            }

            return RelativeTo != null ? RelativeTo.transform.rotation * VelocitySource.GetAngularVelocity() : VelocitySource.GetAngularVelocity();
        }
    }
}