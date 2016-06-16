using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelected : MonoBehaviour {

    public Button[] numberButtons = new Button[10];
    public Sprite[] characters = new Sprite[4];
    public Button[] characterButton = new Button[2];

    enum charState : int
    {
        male_selected = 0,
        male_notSelected = 1,
        female_selected = 2,
        female_notSelected = 3
    }

    enum character : int
    {
        male = 0,
        female = 1
    }

    private bool isNumberSelected;

	public void boySelected(){

        characterButton[(int)character.male].image.sprite = characters[(int)charState.male_selected];
        characterButton[(int)character.female].image.sprite = characters[(int)charState.female_notSelected];

		PlayerPrefs.SetString ("gender", "boy");
	}

	public void girlSelected(){

        characterButton[(int)character.male].image.sprite = characters[(int)charState.male_notSelected];
        characterButton[(int)character.female].image.sprite = characters[(int)charState.female_selected];

        PlayerPrefs.SetString ("gender", "girl");
	}

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void PickNumber (int btnNumber)
    {
        PlayerPrefs.SetInt("pickedNumber", btnNumber);
    }
}
