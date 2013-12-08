using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainPlane : MonoBehaviour {

	List<GameObject> nodes;

	// Use this for initialization
	void Start () {
		nodes = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		Event e = Event.current;
		if (e.button == 0 && e.isMouse) {
			if(Input.GetMouseButtonUp(0)){
				Debug.Log("Left Click");
				AddNode();
			}
		} else if (e.button == 1 && e.isMouse) {
			if(Input.GetMouseButtonUp(1)){
				Debug.Log("Right Click");
			}
		}
	}

	void AddNode() {
		GameObject node = (GameObject) Instantiate(Resources.Load("Circle"));
		this.nodes.Add (node);
	}
}
