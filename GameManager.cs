using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

	// make game manager public static so can access this from other scripts
	public static GameManager gm;


	public AudioSource song;

	public GameObject Lose;
	public GameObject ResetGame;
	public GameObject ExitGame;
	public GameObject BalloonSpawners;
	public GameObject Player;


	AudioSource music;

	private int finalScore;
	int health;

	void Awake ()
	{
		

		Lose.SetActive (false);
		ResetGame.SetActive (false);
		ExitGame.SetActive (false);


		BalloonSpawners.SetActive (true);
		Player.SetActive (true);
	}

	// setup the game
	void Start ()
	{
		
		// get a reference to the GameManager component for use by other scripts
		if (gm == null)
			gm = this.gameObject.GetComponent<GameManager> ();

	}

	// this is the main game event loop
	void Update ()
	{

	}
		



	public void BadEndGame ()
	{
		// game is over

		Lose.SetActive (true);
		ResetGame.SetActive (true);
		ExitGame.SetActive (true);

		BalloonSpawners.SetActive (false);
		Player.SetActive (false);


		ScoreManager.score = finalScore;
		/*song.volume = 0.3f;
		song.pitch = 0.8f;*/
	}

	public void ResetLevel ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}


	// public function that can be called to exit the game
	public void ReturnToMainMenu ()
	{
		
		SceneManager.LoadScene ("MainMenu");

	}
		

}
