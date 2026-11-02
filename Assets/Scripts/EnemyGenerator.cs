using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    public GameObject enemy;
    public Camera cam;

    public float spawnInterval = 2f;
    public float spawnOffset = 2f;

    void Start() {
        if (cam == null)
            cam = Camera.main;

        InvokeRepeating(nameof(Spawn), 3f, spawnInterval);
    }

    void Spawn() {
        if (enemy == null || cam == null)
            return;

        // Posición vertical aleatoria
        float randomY = Random.Range(0.1f, 0.9f);

        // Borde derecho de la cámara
        Vector3 pos = cam.ViewportToWorldPoint(
            new Vector3(1f, randomY,
                Mathf.Abs(enemy.transform.position.z - cam.transform.position.z))
        );

        // Generar fuera de la cámara
        pos.x += spawnOffset;

        // Mantener la profundidad del enemigo
        pos.z = enemy.transform.position.z;

        // Crear una copia del prefab
        Instantiate(enemy, pos, Quaternion.identity);
    }
}