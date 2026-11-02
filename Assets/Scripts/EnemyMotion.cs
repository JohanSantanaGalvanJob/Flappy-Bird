using UnityEngine;

public class EnemyMotion : MonoBehaviour {
    public int enemySpeed = 5;

    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();

        // Mover el enemigo hacia la izquierda
        rb.linearVelocity = new Vector3(-enemySpeed, 0, 0);
    }
}