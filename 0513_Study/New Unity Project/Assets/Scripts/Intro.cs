using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

	private SceneManager sceneManager = new SceneManager();
	private string loadScene = "Main";


	public void BTN_OnClick_Start()
	{
		Debug.Log ("Use Button");
		SceneManager.LoadScene (loadScene);
	}
}