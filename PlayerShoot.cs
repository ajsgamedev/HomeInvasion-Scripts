using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public GameObject LazerPrefab;
	//public AudioClip LazerSound;

	public float fireDelay = 0.25f;
	private float cooldownTimer = 0;

	// Update is called once per frame
	void Update ()
	{
		cooldownTimer -= Time.deltaTime;

		if (Input.GetButton ("Fire1") && cooldownTimer <= 0)
		{
			cooldownTimer = fireDelay;

			//Fire Lazer from Gun barrel position
			GameObject newProjectile = Instantiate (LazerPrefab, transform.position, transform.rotation) as GameObject;

			/*if (LazerSound)
			{
				if (newProjectile.GetComponent<AudioSource> ())
				{ // the projectile has an AudioSource component
					// play the sound clip through the AudioSource component on the gameobject.
					// note: The audio will travel with the gameobject.
					newProjectile.GetComponent<AudioSource> ().PlayOneShot (LazerSound);
				}
				else
				{
					// dynamically create a new gameObject with an AudioSource
					// this automatically destroys itself once the audio is done
					AudioSource.PlayClipAtPoint (LazerSound, newProjectile.transform.position);
				}
			}*/
		}
	}
}
