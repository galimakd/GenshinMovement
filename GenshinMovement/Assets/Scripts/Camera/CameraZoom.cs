using Cinemachine;
using UnityEngine;

namespace GenshinMovement
{
    public class CameraZoom : MonoBehaviour
    {
        [SerializeField] [Range(0f,10f)] private float defaultDistance = 6f;

        [SerializeField] [Range(0f, 10f)] private float minimumDistance = 1f;

        [SerializeField] [Range(0f, 10f)] private float maximumDistance = 6f;

        [SerializeField][Range(0f, 10f)] private float smoothing = 4f;

        [SerializeField][Range(0f, 10f)] private float zoomSensitivity = 1f;


        //for reference in components
        private CinemachineFramingTransposer framingTransposer;

        private CinemachineInputProvider inputProvider;

        private float currentTargetDistance;

        private void Awake()
        {
            framingTransposer = GetComponent<CinemachineVirtualCamera>().GetCinemachineComponent<CinemachineFramingTransposer>();//call framing transposer
            inputProvider = GetComponent<CinemachineInputProvider>();//call input provider

            currentTargetDistance = defaultDistance;
        }

        private void Update()
        {
            Zoom();
        }

        private void Zoom()
        {
            float zoomValue = inputProvider.GetAxisValue(2) * zoomSensitivity;

            currentTargetDistance = Mathf.Clamp(currentTargetDistance + zoomValue, minimumDistance, maximumDistance);

            float currentDistance = framingTransposer.m_CameraDistance;

            if (currentDistance == currentTargetDistance)
            {
                return;
            }

            float lerpedZoomValue = Mathf.Lerp(currentDistance, currentTargetDistance, smoothing * Time.deltaTime);

            framingTransposer.m_CameraDistance = lerpedZoomValue;
        }


    }
}
