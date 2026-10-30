using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject enemy;
    void Start()
    {
        InvokeRepeating("spawn", 3.0f, 1.0f);
    }

    // Update is called once per frame
    private void spawn() {
        Instantiate(enemy, Vector2.zero, Quaternion.identity);
    }

    void Update()
    {
        //Instantiate(enemy, Vector2.zero, Quaternion.identity);
    }
}
