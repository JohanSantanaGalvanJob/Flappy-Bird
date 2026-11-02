
using UnityEngine;

public class DestroyOnExit : MonoBehaviour {


    void Start() {
    }

    void Update() {
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("LeftCollision")) {
            Destroy(gameObject);
        }
    }
}
