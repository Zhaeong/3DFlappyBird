using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {
    private Rigidbody rb;
    public float jumpHeight = 14;
    public float speed = 5;
    public Text scoreText;

    private bool showGUI  = false;
    public static int scoreCounter;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        scoreCounter = 0;
        scoreText.text = scoreCounter.ToString();
       

    }

    void FixedUpdate()
    {
        /* horizontal and vertical movement to be added later
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        */
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(0, jumpHeight * jump, 0);
        
        //if (rb.velocity.magnitude <= 5)
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
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
        if (other.CompareTag("ScoreCollision"))
        {
            scoreCounter += 1;
            scoreText.text = scoreCounter.ToString();

        }
    }

    void OnGUI()
    {
        if (showGUI)
        {
            //The commented out code displays a button, kinda clunky and not necessary
            //if (GUI.Button(new Rect(10, 10, 150, 100), "Restart") || Input.GetKeyDown("r") || Input.GetKeyDown("space"))
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }

    }
}
