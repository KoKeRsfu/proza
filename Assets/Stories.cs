using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Stories : MonoBehaviour
{
	public int currentStory;
	
	public List<Button> buttons;
	
	[SerializeField] swipe contentSwipe;
	
	[SerializeField] Transform activeSlide;
	
    void Start()
    {
	    
    }

    void Update()
    {

	    
	    
    }
    
	public void SwipeLeft() 
	{
		if (currentStory < buttons.Count - 1) currentStory +=1;
		
		contentSwipe.WhichBtnClicked(currentStory);
		
		activeSlide.SetSiblingIndex(currentStory);

	}
	
	public void SwipeRight() 
	{
		if (currentStory > 0) currentStory -=1;
		
		contentSwipe.WhichBtnClicked(currentStory);

		activeSlide.SetSiblingIndex(currentStory);
	}

}
