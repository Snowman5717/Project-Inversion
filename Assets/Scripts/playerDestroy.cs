using UnityEngine;
using System.Collections;

public class playerDestroy : MonoBehaviour 
{

    Vector3 spawnPoint;

    public static bool reset = false;

	// Use this for initialization
	void Start () 
    {
        spawnPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Obstacle")
        {

            reset = true;
            transform.position = spawnPoint;
        }
    }
}
