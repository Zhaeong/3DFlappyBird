using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float jumpHeight = 14;
    public float speed = 5;

    private bool showGUI  = false;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        //rb.mass = 10f;

    }

    void FixedUpdate()
    {
        /* horizontal and vertical movement to be added later
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        */
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(0, jumpHeight * jump, 0);
        
        if (rb.velocity.magnitude <= 5)
        {
            rb.AddForce(movement, ForceMode.Impulse);            
        }
        

    }
    // Update is called once per frame
    void Update () {

	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrier"))
        {
            Debug.Log("Collided");
            Time.timeScale = 0;
            showGUI = true;
        }
    }

    void OnGUI()
    {
        if (showGUI)
        {
            if (GUI.Button(new Rect(10, 10, 150, 100), "Restart"))
            {
                Application.LoadLevel(0);
                Time.timeScale = 1;
            }
        }

    }
}
