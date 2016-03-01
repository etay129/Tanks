using UnityEngine;
using System.Collections;


public class BulletShooter : MonoBehaviour {

	// Make empty GameObject "bulletEmitter" at mouth of gun
	// Drag/drop in
	//public GameObject myo = null;
	public GameObject bulletEmitter;

	// Drag/drop in bullet prefab
	public GameObject bullet;

	// Enter in speed from inspector
	public float speed;


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space")) {
			GameObject tempBulletHandler = Instantiate (bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
			tempBulletHandler.transform.Rotate (Vector3.left * 90);

			Rigidbody tempRB;
			tempRB = tempBulletHandler.GetComponent<Rigidbody> ();

			tempRB.AddForce (transform.forward * speed);

			// deletes bullet after 10s
			Destroy (tempBulletHandler, 3.0f);
		}
	}


}
