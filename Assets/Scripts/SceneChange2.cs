using UnityEngine;
using System.Collections;

public class SceneChange2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// change the scene after 60 seconds
		if ( Time.timeSinceLevelLoad > 15f ) {
			AutoFade.LoadLevel("Initial" ,1,1,Color.black);
		}
		
		// change the scene if you press R
		if (Input.GetKey (KeyCode.R) ) 
		{
			AutoFade.LoadLevel("Initial" ,1,1,Color.black);
		}
		
	}
}