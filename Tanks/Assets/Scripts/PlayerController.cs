using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float rotationSpeed;

	void Update () {
		
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;

		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}
		
//	void LateUpdate() {
//		Vector3 pos = transform.position;
//		pos.y = Terrain.activeTerrain.SampleHeight(transform.position) + 0.5f;
//		transform.position = pos;

//		Ray heightDetect = new Ray (transform.position, Vector3.down);
//		RaycastHit hit = new RaycastHit ();

//		if (Physics.Raycast (heightDetect, out hit, Mathf.Infinity)) {
//			Debug.Log (hit.distance);

//			var targetRotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
//			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);


//			Debug.DrawRay (heightDetect.origin, heightDetect.direction*1000);

//		}
//	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Add Speed")) {

			other.gameObject.SetActive (false);
		}
	}


}