using UnityEngine;

public class CameraFollowX : MonoBehaviour
{
    public Transform player;
    public float offsetY = 0f;
    public float offsetZ = -10f;

    void LateUpdate() {
        if (player != null) {
            transform.position = new Vector3(player.position.x, transform.position.y + offsetY, offsetZ);
        }
    }
}
