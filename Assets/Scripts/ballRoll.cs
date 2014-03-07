using UnityEngine;
using System.Collections;

public class ballRoll : MonoBehaviour {


	
	// Update is called once per frame
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
				if (Input.GetKey (KeyCode.UpArrow)) {
						GetComponent<Rigidbody> ().AddRelativeForce (transform.forward * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.DownArrow)) {
						GetComponent<Rigidbody> ().AddRelativeForce (-transform.forward * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.LeftArrow)) {
						GetComponent<Rigidbody> ().AddRelativeForce (-transform.right * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.RightArrow)) {
						GetComponent<Rigidbody> ().AddRelativeForce (transform.right * 20f, ForceMode.Acceleration);
				}
				
		}

}
