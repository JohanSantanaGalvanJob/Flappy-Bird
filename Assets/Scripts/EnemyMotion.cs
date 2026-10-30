using UnityEngine;

public class EnemyMotion : MonoBehaviour
{
    public int enemySpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomPosition();
        GetComponent<Rigidbody>().linearVelocity = new Vector2(-enemySpeed, 0);
    }

    private void randomPosition() {
        int position = Random.Range(-5, 5);
        GetComponent<Rigidbody>().position = new Vector2(10, position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
