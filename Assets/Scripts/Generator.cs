// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public Transform Cylinder;
	public int num_items;
	public int min;
	public int max;

	Vector3 GeneratedPosition()
	{
		int x,y,z;
		x = UnityEngine.Random.Range(min,max);
		y = UnityEngine.Random.Range(min,max);
		z = UnityEngine.Random.Range(min,max);
		return new Vector3(x,y,z);
	}

	void Start() {
		for (int i = 0; i < num_items; i++) {
			Instantiate(Cylinder, GeneratedPosition(), Quaternion.identity);
		}
	}
}
