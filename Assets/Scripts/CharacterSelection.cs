using UnityEngine;
using System.Collections;

public class CharacterSelection : MonoBehaviour {

    void maleCharacterSelected()
    {
        PlayerPrefs.SetString("character", "male");
    }

    void femaleCharacterSelected()
    {
        PlayerPrefs.SetString("character", "female");
    }
}
