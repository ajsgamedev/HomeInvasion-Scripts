using UnityEngine;
using System.Collections;

public class TimedObjectDestroyer : MonoBehaviour {

	public float timeOut = 3.0f;
	public bool detachChildren = false;

	// Use this for initialization
	void Awake () 
	{
		Invoke ("DestroyNow", timeOut);
	}
	
	// Update is called once per frame
	void DestroyNow () 
	{
		if (detachChildren)
		{
			transform.DetachChildren ();
		}
		Destroy (gameObject);
	}
}
