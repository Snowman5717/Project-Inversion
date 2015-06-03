using UnityEngine;
using System.Collections;

public class playerDestroy : MonoBehaviour 
{

    Vector3 spawnPoint;

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
            transform.position = spawnPoint;
        }
    }
}
