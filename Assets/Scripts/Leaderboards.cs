using UnityEngine;
using System.Collections;

public class Leaderboards : MonoBehaviour {

    private int pont1;
    private int pont2;
    private int pont3;

	// Use this for initialization
	void Start () {
	
	}
	
    public int Maior()
    {
        if (pont1 > pont2 && pont1 > pont3)
            return pont1;
        if (pont2 > pont1 && pont2 > pont3)
            return pont2;
        if (pont3 > pont1 && pont3 > pont2)
            return pont3;
        return 0;
    }


    public int menor()
    {
        if (pont1 < pont2 && pont1 < pont3)
            return pont1;
        if (pont2 < pont1 && pont2 < pont3)
            return pont2;
        if (pont3 < pont1 && pont3 < pont2)
            return pont3;
        return 0;
    }
}
