using UnityEngine;
using System.Collections;

public class WorldMovement : MonoBehaviour {

	public float speed = 0;
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(-speed * Time.deltaTime, 0,0); 
	}
}
