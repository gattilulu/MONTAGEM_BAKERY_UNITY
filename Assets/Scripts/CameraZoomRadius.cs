using UnityEngine;
using Unity.Cinemachine;

public class CameraZoomRadius : MonoBehaviour
{
    [SerializeField] CinemachineOrbitalFollow orbital;
    [SerializeField] float zoomSpeed = 0.8f;
    [SerializeField] float minRadius = 2f;
    [SerializeField] float maxRadius = 8f;

    void Reset()
    {
        orbital = GetComponent<CinemachineOrbitalFollow>();
    }

    void Update()
    {
        if (!orbital) return;

        float scroll = Input.mouseScrollDelta.y; // funciona com Active Input Handling = Both
        if (Mathf.Abs(scroll) < 0.001f) return;

        orbital.Radius = Mathf.Clamp(orbital.Radius - scroll * zoomSpeed, minRadius, maxRadius);
    }
}
