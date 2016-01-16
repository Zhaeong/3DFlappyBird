using UnityEngine;
using System.Collections;

public class BarrierMovement : MonoBehaviour {
    public float speed = 5;
	// Use this for initialization
	void Start () {
	
	}

    void FixedUpdate() {
        Vector3 vNewPosition = transform.position;
        vNewPosition.y -= 0.001f;
        transform.Translate(Time.deltaTime * speed, 0, 0);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
