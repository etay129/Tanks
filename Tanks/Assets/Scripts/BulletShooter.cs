using UnityEngine;
using System.Collections;


public class BulletShooter : MonoBehaviour {

	public GameObject bulletEmitter;
	public GameObject bullet;
	public float speed;

	void Update () {

		if (Input.GetKeyDown("space")) {

			GameObject tempBulletHandler = Instantiate (bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
			tempBulletHandler.transform.Rotate (Vector3.left * 90);

			Rigidbody tempRB;
			tempRB = tempBulletHandler.GetComponent<Rigidbody> ();

			tempRB.AddForce (transform.forward * speed);

		}
	}


}
