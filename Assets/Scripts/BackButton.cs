using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	public string back;


	public void BackToMain()
	{
		SceneManager.LoadScene (back);
	}
}