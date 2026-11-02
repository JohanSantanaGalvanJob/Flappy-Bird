using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDeath : MonoBehaviour {
    [SerializeField] private GameObject gameOverText;

    private bool isDead = false;

    void Start() {
        Time.timeScale = 1f;
        gameOverText.SetActive(false);
    }

    void Update() {
        if (isDead && Input.GetKeyDown(KeyCode.R)) {
            RestartGame();
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Enemy") && !isDead) {
            Die();
        }
    }

    void Die() {
        isDead = true;
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }

    void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}