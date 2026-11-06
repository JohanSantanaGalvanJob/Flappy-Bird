using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody rig;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       float lHorizontal = Input.GetAxis("Horizontal");
        if(lHorizontal > 0) {
            rig.linearVelocity = (transform.right * speed * Input.GetAxis("Horizontal")) + (transform.up * rig.linearVelocity.y);

            if (Input.GetButtonDown("Jump")) {
                rig.AddForce(transform.up * jumpForce);
            }
        }
       
    }
}
