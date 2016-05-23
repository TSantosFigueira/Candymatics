using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public static float time = 33;
    private Text timeText;
    private bool canGo = false;

	// Use this for initialization
	void Start () {
        timeText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        timeText.text = time.ToString("f0");

        if(time <= 0)
        {
            time = 0;
        }
	}
}
