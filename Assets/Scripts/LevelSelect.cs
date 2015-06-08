using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour 
{
	public void ReturnToMainMenu()	
	{
		Application.LoadLevel(0);
	}
}
