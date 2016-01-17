using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float speed = 5;
    public static int scoreCounter;
    

    // Use this for initialization
    void Start () {
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
            float fSize = Random.Range(6.0f, 21.0f);
            Vector3 vStartPos = new Vector3(-25, fSize, 0);	        
            transform.position = vStartPos;
        }
    }
}
