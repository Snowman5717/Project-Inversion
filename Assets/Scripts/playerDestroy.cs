﻿using UnityEngine;
using System.Collections;

public class playerDestroy : MonoBehaviour 
{

    public static bool reset = false;
	public static bool died;
	
	// Use this for initialization
	void Start () 
    {
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
			died = true;
            reset = true;
            Application.LoadLevel(2);
        }
        if(col.gameObject.tag == "EndPortal")
        {
        	died = false;
			Application.LoadLevel(2);
        }
    }
}
