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
						GetComponent<Rigidbody> ().AddForce (-Vector3.forward * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.DownArrow)) {
						GetComponent<Rigidbody> ().AddForce (Vector3.forward * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.LeftArrow)) {
						GetComponent<Rigidbody> ().AddForce (Vector3.right * 20f, ForceMode.Acceleration);
				}
				if (Input.GetKey (KeyCode.RightArrow)) {
						GetComponent<Rigidbody> ().AddRelativeForce (-Vector3.right * 20f, ForceMode.Acceleration);
				}
				
		}

}
