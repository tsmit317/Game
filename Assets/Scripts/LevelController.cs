using UnityEngine;
using System.Collections;

public class LevelController : MonoBehaviour {

	public GameObject currentCheckpoint;
	private SonicControllerScript sonic;


	//Finds character
	void Start () 
	{
		sonic = FindObjectOfType<SonicControllerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Moves character to current checkpoint position
	public void respawnCharacter()
	{
		sonic.transform.position = currentCheckpoint.transform.position;
	}
}
