using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {


	public float startingTime;
	private Text tex;

	public GameObject gameOverScene;
	public SonicControllerScript character;
	public string mainMenu;
	public float screenTime;

	// Use this for initialization
	void Start () 
	{
		tex = GetComponent<Text> ();
		character = FindObjectOfType<SonicControllerScript> ();
	}
	

	void Update () {
		
		startingTime -= Time.deltaTime;

		tex.text = "" + Mathf.Round(startingTime);

		if (startingTime < 0) 
		{
			gameOverScene.SetActive (true);
			character.gameObject.SetActive (false);
		}
		if (gameOverScene.activeSelf) 
		{
			screenTime -= Time.deltaTime;
		}

		if (screenTime < 0) 
		{
			SceneManager.LoadScene (mainMenu);
		}
	}
}
