using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeathZone : MonoBehaviour {

	public static DeathZone dz;

	public int TotalLifePoints = 100;
	public int LivePoints = 100;
	public int DamagePerHit = 10;
	public Image healthBar;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			LivePoints -= DamagePerHit;
			healthBar.GetComponent<Image> ().fillAmount = 
				(float)LivePoints / TotalLifePoints;
			
			DestroyObject (other.gameObject);
		}
		else
		{
			DestroyObject (other.gameObject);
		}
	}

	void Update()
	{
		if (LivePoints <= 0)
		{
			GameManager.gm.BadEndGame();
		}
	}


}
