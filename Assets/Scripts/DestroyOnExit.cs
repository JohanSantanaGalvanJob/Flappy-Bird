
using UnityEngine;

public class DestroyOnExit : MonoBehaviour {


    void Start() {
    }

    void Update() {
    }

    public void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
