using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float speed = 5;
    public int scoreCounter;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreCounter = 0;
        scoreText.text = "Score:" + scoreCounter.ToString();
	}

    void FixedUpdate() {
        Vector3 vNewPosition = transform.position;
        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndWall"))
        {
            float fSize = Random.Range(7.0f, 18.0f);            
            Vector3 vStartPos = new Vector3(-20, fSize, 0);
            transform.position = vStartPos;           
            scoreCounter += 10;
            Debug.Log("Collided ");
            Debug.Log(scoreCounter);
            scoreText.text = "Score:" + scoreCounter.ToString();
        }
    }
}
