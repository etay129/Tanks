using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {

	public float amplitude;          
	public float speed;                  
	private float tempVal;
	private Vector3 tempPos;

	void Start() {
		tempVal = transform.position.y;
	}

	void Update () {

		tempPos.y = tempVal + amplitude * Mathf.Sin(speed * Time.time);
		transform.position = tempPos;
	}
}
