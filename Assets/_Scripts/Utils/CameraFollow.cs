namespace ClicheSurvivors.Utils
{
    using UnityEngine;

    public class CameraFollow : MonoBehaviour
    {
        [field: SerializeField]
        public Transform FollowTarget { get; set; }

        private void Update()
        {
            if (this.FollowTarget)
            {
                this.transform.position = new Vector3(FollowTarget.position.x, FollowTarget.position.y, this.transform.position.z);
            }
        }
    }
}
