using UnityEngine;

[RequireComponent(typeof(CameraRaycaster))]
public class CursorAffordance : MonoBehaviour
{
    [SerializeField] Texture2D walkCursor = null;
    [SerializeField] Texture2D targetCursor = null;
    [SerializeField] Texture2D unknownCursor = null;

    [SerializeField] Vector2 hotspot = new Vector2(0, 0);

    CameraRaycaster cameraRaycaster;

    void Start()
    {
        cameraRaycaster = GetComponent<CameraRaycaster>();
        cameraRaycaster.OnLayerChangeObservers += OnLayerChange;
    }

    void OnLayerChange(Layer newLayer)
    {
        switch(newLayer)
        {
            case Layer.Walkable:
                Cursor.SetCursor(walkCursor, hotspot, CursorMode.Auto);
                break;
            case Layer.Enemy:
                Cursor.SetCursor(targetCursor, hotspot, CursorMode.Auto);
                break;
            case Layer.RaycastEndStop:
                Cursor.SetCursor(unknownCursor, hotspot, CursorMode.Auto);
                break;
            default:
                break;
        }
    }
}
