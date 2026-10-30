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
       rig.linearVelocity = (transform.right * speed * Input.GetAxis("Horizontal")) + (transform.up * rig.linearVelocity.y);
       if(rig.linearVelocity.x > 0.1f) {
            GetComponent<SpriteRenderer>().flipX = false;
        } else if (rig.linearVelocity.x < -0.1f) {
            GetComponent<SpriteRenderer>().flipX=true;
        }

        if (Input.GetButtonDown("Jump")) {
            rig.AddForce(transform.up * jumpForce);
        }
    }
}
