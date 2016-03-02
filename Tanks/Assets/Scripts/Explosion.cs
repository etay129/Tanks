// A bullet
// - plays explosion when hitting a surface
// - then destroys itself

using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public GameObject explosion;

	void OnCollisionEnter(Collision collision) {
		ContactPoint contact = collision.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		var exp = Instantiate (explosion, pos, rot) as GameObject;
		Destroy(gameObject);
		Destroy (exp, exp.GetComponent<ParticleSystem> ().duration);
	}

}