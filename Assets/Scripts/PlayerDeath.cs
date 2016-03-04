using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

	public LevelController levelcontrol;

	//Finds any objects that have level manager attached
	void Start () 
	{
		levelcontrol = FindObjectOfType<LevelController> ();
	}
	

	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D thing)
	{
		if (thing.name == "Character") 
		{
			levelcontrol.respawnCharacter ();
		}
	}
}
