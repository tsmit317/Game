using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour {

	public LevelController levelcontrol;
	public GameObject winScene;
	public SonicControllerScript character;
	public float winScreenTime;
	public string mainMenu;

	//Finds any objects that have level manager attached
	void Start () 
	{
		levelcontrol = FindObjectOfType<LevelController> ();
	}

	void Update () 
	{
		if (winScene.activeSelf) 
		{
			winScreenTime -= Time.deltaTime;
		}

		if (winScreenTime < 0) 
		{
			SceneManager.LoadScene (mainMenu);
		}
	}

	void OnTriggerEnter2D(Collider2D thing)
	{
		if (thing.name == "Character") 
		{
			winScene.SetActive (true);
			character.gameObject.SetActive (false);


		}
			
	}
}

