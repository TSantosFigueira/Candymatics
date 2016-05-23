using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FlowController : MonoBehaviour {

	public void replay() {
		SceneManager.LoadScene ("Game");
	}

	public void menu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
