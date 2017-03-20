using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

	public int TotalLifePoints = 100;
	public int LivePoints = 100;
	public int DamagePerHit = 10;
	public AudioClip hitSFX;
	public float flashSpeed = 5f;
	public Color flashColour = new Color (1f, 0f, 0f, 0.1f);
	public Image damageImage;

	AudioSource _audio;
	bool damaged;
	// Use this for initialization
	void Start ()
	{
		_audio = GetComponent<AudioSource> ();
		LivePoints = TotalLifePoints;

	}

	void Update ()
	{
		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}


	void OnTriggerEnter (Collider coll)
	{
		if (coll.gameObject.tag == "Enemy")
		{
			HandleHit ();
		}
	}

	void HandleHit ()
	{
		damaged = true;

		LivePoints -= DamagePerHit;
		_audio.PlayOneShot (hitSFX);

		GameObject.FindGameObjectWithTag ("pHealth").GetComponent<Image> ().fillAmount = 
				(float)LivePoints / TotalLifePoints;

		if (LivePoints <= 0)
			HandleDeath ();
	}

	void HandleDeath ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
