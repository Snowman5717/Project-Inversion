using UnityEngine;
using System.Collections;

public class backgroundReset : MonoBehaviour {

    Vector3 initPos;

	// Use this for initialization
	void Start () {

        initPos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

        if(playerDestroy.reset == true)
        {
            transform.position = initPos;
            playerDestroy.reset = false;
        }

        
	
	}
}
