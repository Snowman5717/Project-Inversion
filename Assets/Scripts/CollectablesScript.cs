using UnityEngine;
using System.Collections;

public class CollectablesScript : MonoBehaviour {

	public GameObject collectable;
	public static int count=0;
	void OnTriggerEnter (Collider other)
	{
			if (gameObject == collectable) {

				Destroy (collectable);
			count++;
			}
		Debug.Log (count);

			}

		}
	


