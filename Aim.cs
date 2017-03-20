using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = Input.mousePosition;           
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

		transform.LookAt(new Vector3(mousePosition.x, mousePosition.y, transform.position.x));
		Quaternion rot = Quaternion.LookRotation( transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;  
		transform.eulerAngles = new Vector3(0, 0,transform.eulerAngles.z);
	
	}




}
