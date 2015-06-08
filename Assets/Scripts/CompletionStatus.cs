using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CompletionStatus : MonoBehaviour 
{
	public Sprite success, failed;
	Image image;
	
	void Start () 
	{
		image = GetComponent<Image>();
	}
	
	void Update()
	{
		if(playerDestroy.died)
		{
			image.sprite = failed;
		}
		else
		{
			image.sprite = success;
		}
	}
}
