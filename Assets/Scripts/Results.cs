using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Results : MonoBehaviour {

	public Sprite bronze;
	public Sprite silver;
	public Sprite gold;

	public Text score;
	public Text highScore;

	private int highestScore;
	private int finalScore;

	// Use this for initialization
	void Start () {

		finalScore = PlayerPrefs.GetInt ("score", 0);

		if (finalScore <= 7)
			gameObject.GetComponent<Image> ().sprite = bronze;
		else if (finalScore > 7 && finalScore <= 12)
			gameObject.GetComponent<Image> ().sprite = silver;
		else
			gameObject.GetComponent<Image> ().sprite = gold;
		
		highestScore = PlayerPrefs.GetInt ("highScore", 0);

		score.text = finalScore.ToString ();
		highScore.text = highestScore.ToString ();
	}
}
