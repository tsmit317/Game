using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	public LevelController levelcontrol;

	//Finds any objects that have level manager attached
	void Start () 
	{
		levelcontrol = FindObjectOfType<LevelController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//When character object triigers collider object
	void OnTriggerEnter2D(Collider2D thing)
	{
		if (thing.name == "Character") 
		{
			levelcontrol.currentCheckpoint = gameObject;

		}
	}
}
