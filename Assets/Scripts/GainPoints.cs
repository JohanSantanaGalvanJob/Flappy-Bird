using TMPro;
using UnityEngine;

public class GainPoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI points;

    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        if (collision != null) {
            if (collision.CompareTag("PointsCollision")) {
                score++;
                points.text = score.ToString();
            }
        }
    }
}
