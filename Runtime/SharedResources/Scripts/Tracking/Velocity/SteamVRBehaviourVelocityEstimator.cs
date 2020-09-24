namespace Tilia.SDK.SteamVR.Tracking.Velocity
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Valve.VR;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// Retrieves the velocity and angular velocity from the specific <see cref="SteamVR_Behaviour_Pose"/>.
    /// </summary>
    public class SteamVRBehaviourVelocityEstimator : VelocityTracker
    {
        /// <summary>
        /// The <see cref="SteamVR_Behaviour_Pose"/> to track velocity for.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public SteamVR_Behaviour_Pose VelocitySource { get; set; }
        /// <summary>
        /// An optional <see cref="GameObject"/> to consider the source relative to when retrieving velocities.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public GameObject RelativeTo { get; set; }

        /// <inheritdoc />
        public override bool IsActive()
        {
            return gameObject.activeInHierarchy && isActiveAndEnabled;
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