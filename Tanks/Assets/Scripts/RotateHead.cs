using UnityEngine;
using System.Collections;

public class RotateHead : MonoBehaviour {

	public float rotationSpeed;

	private Vector3 initialAngle;
	private Vector3 curAngles;

	void Start() {
		initialAngle = transform.localEulerAngles;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("z")) {
			curAngles.y -= rotationSpeed * Time.deltaTime;
			//transform.Rotate (new Vector3 (0, -rotationSpeed, 0) * Time.deltaTime);
	
		}
		if (Input.GetKey ("c")) {
			curAngles.y += rotationSpeed * Time.deltaTime;
			//transform.Rotate (new Vector3 (0, rotationSpeed, 0) * Time.deltaTime);
		}

		curAngles.y = Mathf.Clamp(curAngles.y, -90, 90); 
		transform.localEulerAngles = initialAngle + curAngles; 
	
	}
}
