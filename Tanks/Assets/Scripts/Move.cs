using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	// A very simplistic car driving on the x-z plane.

	public float speed;
	public float rotationSpeed;

	//var speed : float = 10.0;
	//var rotationSpeed : float = 100.0;

	void Update () {
		// Get the horizontal and vertical axis.
		// By default they are mapped to the arrow keys.
		// The value is in the range -1 to 1
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;


		// Make it move 10 meters per second instead of 10 meters per frame...
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		// Move translation along the object's z-axis
		transform.Translate (0, 0, translation);
		// Rotate around our y-axis
		transform.Rotate (0, rotation, 0);
	}
		
	void LateUpdate() {
		Vector3 pos = transform.position;
		pos.y = Terrain.activeTerrain.SampleHeight(transform.position) + 0.5f;
		transform.position = pos;

		Ray heightDetect = new Ray (transform.position, Vector3.down);
		RaycastHit hit = new RaycastHit ();

		if (Physics.Raycast (heightDetect, out hit, Mathf.Infinity)) {
			Debug.Log (hit.distance);

			//transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;


			var targetRotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);


			Debug.DrawRay (heightDetect.origin, heightDetect.direction*1000);

		}


	}
}