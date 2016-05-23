using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterSelected : MonoBehaviour {

	public void boySelected(){
		PlayerPrefs.SetString ("gender", "boy");
		SceneManager.LoadScene ("Game");
	}

	public void girlSelected(){
		PlayerPrefs.SetString ("gender", "girl");
		SceneManager.LoadScene ("Game");
	}
}
