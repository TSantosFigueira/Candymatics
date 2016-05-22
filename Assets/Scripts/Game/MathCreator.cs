using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MathCreator : MonoBehaviour {

    public Text number1;
    public Text number2;

    public Button[] options = new Button[4];

    private int i_number1;
    private int i_number2;
    private int i_answer;

    // Use this for initialization
    void Start () {
        operateIt();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void operateIt()
    {
        i_number1 = Random.Range(1, 10);
        i_number2 = Random.Range(1, 10);
        i_answer = i_number1 * i_number2;

        number1.text = i_number1.ToString(); // publiciza o primeiro operando
        number2.text = i_number2.ToString(); // publiciza o segundo operando

        for (int i = 0; i < options.Length; i++) // povoa as opções
        {
            options[i].GetComponentInChildren<Text>().text = Random.Range(1, 100).ToString();
        }

        switch (Random.Range(1, 4))  // Coloca a resposta correta em uma das opções
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
        }
    }

    public void optionPicked(Button btn)
    {
        if (btn.GetComponentInChildren<Text>().text == i_answer.ToString())
            Debug.Log("You got it");
        else
            Debug.Log("Not yet");
    }

}
