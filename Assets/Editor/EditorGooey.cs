using UnityEngine;
using System.Collections;

public class EditorGooey : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,200,40), "Loader Menu");

		// Make the planet button
		if(GUI.Button(new Rect(20,40,80,20), "Level 1")) {
			
		}

		// Make the buzzard button.
		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
			
		}
	}
}
