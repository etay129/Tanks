using UnityEngine;
using System.Collections;

public class RotateRArmWRTBody : MonoBehaviour {

	public GameObject body;
	
	void FixedUpdate () {

		transform.position = body.transform.position + body.transform.rotation * Vector3.right * 0.3f;
		transform.rotation = body.transform.rotation;
	}
}
