using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float jump_height = 4;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate() {
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(0, jump_height * jump, 0);
        rb.AddForce(movement);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
