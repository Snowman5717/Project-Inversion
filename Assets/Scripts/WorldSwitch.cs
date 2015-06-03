using UnityEngine;
using System.Collections;

public class WorldSwitch : MonoBehaviour {

	public GameObject World1;
	public GameObject World2;
	private float timeDelay = 3.0f;
	public float timer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer +0.1f;
		if (Input.GetButton("Fire1") && timer >=timeDelay) {
			if (World1.activeInHierarchy) {
				World1.SetActive (false);
				World2.SetActive (true);
				timer=0.0f;
			}
		}

		if (Input.GetButtonDown("Fire1") && timer >timeDelay) {
			if (World2.activeInHierarchy) {
			
				World2.SetActive (false);
				World1.SetActive (true);
				timer=0.0f;
			}
		}
	}
}
