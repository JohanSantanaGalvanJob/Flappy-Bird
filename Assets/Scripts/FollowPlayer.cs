using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;

    public float speed;


    private void Start() {
    }
    // Update is called once per frame
    void Update() {
        float lHorizontal = Input.GetAxis("Horizontal");
        if (lHorizontal > 0) {
            GetComponent<Rigidbody>().linearVelocity = (transform.right * speed * Input.GetAxis("Horizontal")) + (transform.up * GetComponent<Rigidbody>().linearVelocity.y);
        }
    }
}
