using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    //Carrega a primeira fase
	public void playGame()
    {
        SceneManager.LoadScene("Character Selection");
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
