using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class starCount : MonoBehaviour 
{  
    public Sprite oneStar, twoStar, failed;
	Image image;
	
	void Start () 
	{
		image = GetComponent<Image>();
	}

    void Update()
    {
        if (playerDestroy.died)
        {
            image.sprite = failed;
        }
        else if (CollectablesScript.count < 3)
        {
            image.sprite = oneStar;
        }
        else if (CollectablesScript.count == 3)
        {
            image.sprite = twoStar;
        }
    }
}