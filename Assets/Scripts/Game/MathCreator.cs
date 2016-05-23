using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MathCreator : MonoBehaviour {

    public Text number1Text;
    public Text number2Text;
    public Text scoreText;

    public Button[] options = new Button[5];

	public GameObject resultsPanel;

	private int score;
    private int i_number1;
    private int i_number2;
    private int i_answer;
	private int highestScore;

    // Use this for initialization
    void Start () {
        StartCoroutine(sec());
        operateIt();
		highestScore = PlayerPrefs.GetInt ("highScore", 0);
	}
	
	// Update is called once per frame
	void Update () {

		if (score > highestScore) {
			highestScore = score;
			PlayerPrefs.SetInt ("highScore", highestScore);
		}

		PlayerPrefs.SetInt ("score", score);

		if (timer.time == 0) {
			resultsPanel.SetActive (true);
		}
	}

    public void operateIt()
    {
        i_number1 = Random.Range(1, 10);
        i_number2 = Random.Range(1, 10);
        i_answer = i_number1 * i_number2;

        number1Text.text = i_number1.ToString(); // publiciza o primeiro operando
        number2Text.text = i_number2.ToString(); // publiciza o segundo operando

        for (int i = 0; i < options.Length; i++) // povoa as opções
        {
            options[i].GetComponentInChildren<Text>().text = Random.Range(1, 100).ToString();
        }

        switch (Random.Range(1, 5))  // Coloca a resposta correta em uma das opções
        {
            case 1:
                options[0].GetComponentInChildren<Text>().text = i_answer.ToString();
                break;
            case 2:
                options[1].GetComponentInChildren<Text>().text = i_answer.ToString();
                break;
            case 3:
                options[2].GetComponentInChildren<Text>().text = i_answer.ToString();
                break;
            case 4:
                options[3].GetComponentInChildren<Text>().text = i_answer.ToString();
                break;
            case 5:
                options[4].GetComponentInChildren<Text>().text = i_answer.ToString();
                break;
        }
    }

    public void optionPicked(Button btn)
    {
        if (timer.time > 0)
        {
            if (btn.GetComponentInChildren<Text>().text == i_answer.ToString())
            {
                score++;
                scoreText.text = score.ToString();
            }
                
			operateIt();
        }
    }

    IEnumerator sec()
    {
        yield return new WaitForSeconds(1.5f);
    }

}
