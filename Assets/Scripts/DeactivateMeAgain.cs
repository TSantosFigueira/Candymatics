using UnityEngine;
using System.Collections;

public class DeactivateMeAgain : MonoBehaviour {
    private float delay = 1f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
	}
}
