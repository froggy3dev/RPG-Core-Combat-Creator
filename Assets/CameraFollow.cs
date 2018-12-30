using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.localPosition = new Vector3(player.transform.localPosition.x, 0f, player.transform.localPosition.z); 
    }
}
