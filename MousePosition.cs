using UnityEngine;
using System.Collections;

public class MousePosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Vector3 mousePos = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mousePos = Input.mousePosition;
		mousePos = Camera.main.ScreenToWorldPoint(mousePos);
		this.gameObject.transform.position = mousePos;
	
	}
}
