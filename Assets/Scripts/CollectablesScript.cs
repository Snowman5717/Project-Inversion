using UnityEngine;
using System.Collections;

public class CollectablesScript : MonoBehaviour {

	public static int count = 0;

	void OnTriggerEnter (Collider other)
	{
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            count++;
            Debug.Log("test");
        }
	}
}
	


