using UnityEngine;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float speed = 5;
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
            if (gameObject.name == "TopBar")
            {
                Vector3 vStartPos = new Vector3(-10, 3, 0);
                transform.position = vStartPos;
            }
            else if (gameObject.name == "LowerBar")
            {
                Vector3 vStartPos = new Vector3(-10, 6, 0);
                transform.position = vStartPos;
            }

            Debug.Log("Collided ");
        }
        
    }

}
