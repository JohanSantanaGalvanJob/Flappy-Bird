using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
    public GameObject enemy;
    public Camera cam;

    private bool startSpawn = false;

    public float spawnInterval = 2f;
    public float spawnOffset = 2f;

    void Start() {
        cam = Camera.main;

        InvokeRepeating(nameof(Spawn), 3f, spawnInterval);
    }

    void Spawn() {
        if (!startSpawn)
            return;

        // Actualizar cámara si ha cambiado
        Camera currentCam = Camera.main;

        if (currentCam != null && currentCam != cam) {
            cam = currentCam;
        }

        if (enemy == null || cam == null)
            return;

        float randomY = Random.Range(0.3f, 0.9f);

        Vector3 pos = cam.ViewportToWorldPoint(
            new Vector3(
                1f,
                randomY,
                Mathf.Abs(enemy.transform.position.z - cam.transform.position.z)
            )
        );

        // Generar fuera de la cámara actual
        pos.x += spawnOffset;

        // Mantener profundidad
        pos.z = enemy.transform.position.z;

        Instantiate(enemy, pos, Quaternion.identity);
    }

    void Update() {
        float lHorizontal = Input.GetAxis("Horizontal");

        if (lHorizontal > 0) {
            startSpawn = true;
        }
    }
}