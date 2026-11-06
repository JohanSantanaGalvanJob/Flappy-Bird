using UnityEngine;

public class DestroyColumn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update() {
        float lHorizontal = Input.GetAxis("Horizontal");
        if (lHorizontal > 0) {
            Destroy(this.gameObject);
        }

    }
}
