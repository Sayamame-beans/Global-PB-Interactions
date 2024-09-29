using UnityEngine;

namespace Sayabeans.GlobalPBInteraction
{
    [AddComponentMenu("Global PB Interactions/GPI Global Interaction")]
    internal class GlobalInteraction : MonoBehaviour, VRC.SDKBase.IEditorOnly
    {
        public DiversionPoint diversionPoint = DiversionPoint.Auto;
        public Transform rootTransform;
        public float radius = 0;
        public float height = 0;

    }

    internal enum DiversionPoint
    {
        Hands_L,
        Hands_R,
        Finger_Index_L,
        Finger_Index_R,
        Finger_Middle_L,
        Finger_Middle_R,
        Finger_Ring_L,
        Finger_Ring_R,
        Finger_Little_L,
        Finger_Little_R,
        Auto // Auto Mode use Ring > Lottle > Middle
    }
}
