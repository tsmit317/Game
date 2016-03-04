using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string startLevel;
	public string instructions;

	public void NewGame()
	{
		SceneManager.LoadScene (startLevel);
	}

	public void Instructions()
	{
		SceneManager.LoadScene (instructions);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
