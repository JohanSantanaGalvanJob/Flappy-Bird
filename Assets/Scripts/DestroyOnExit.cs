using UnityEngine;

public class DestroyOnExit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
