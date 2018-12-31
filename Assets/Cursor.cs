using UnityEngine;

public class Cursor : MonoBehaviour
{
    CameraRaycaster cameraRaycaster;

    void Start()
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
    }

    void Update()
    {
        Debug.Log(cameraRaycaster.layerHit);
    }
}
