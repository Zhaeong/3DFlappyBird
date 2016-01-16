using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float jump_height = 4;
    public float speed = 5;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        //rb.mass = 10f;

    }

    void FixedUpdate() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(0, jump_height * jump, 0);
        
        if (rb.velocity.magnitude <= 5)
        {
            rb.AddForce(movement, ForceMode.Impulse);
        }

    }
    // Update is called once per frame
    void Update () {
	
	}
}
