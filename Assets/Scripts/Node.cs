using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector3(mousePos.x, mousePos.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 speed = new Vector3 (mousePos.x - transform.position.x, mousePos.y - transform.position.y, 0).normalized;
		transform.position += speed * Time.deltaTime;
	}
}
