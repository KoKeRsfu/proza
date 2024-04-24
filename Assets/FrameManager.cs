using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameManager : MonoBehaviour
{
	private int prevFrame = 0;
	private int currentFrame = 0;
	
    void Start()
    {
	    UpdateFrames();
    }
    
	public void NextFrame() 
	{
		prevFrame = currentFrame;
		if (currentFrame < (transform.childCount - 1)) 
		{
			currentFrame += 1;	
		}
		else 
		{
			currentFrame = 0;
		}
		
		UpdateFrames();
	}
	
	public void PrevFrame() 
	{
		prevFrame = currentFrame;
		if (currentFrame > 0) 
		{
			currentFrame -= 1;	
		}
		else 
		{
			currentFrame = (transform.childCount - 1);
		}
		
		UpdateFrames();
	}
	
	public void SetFrame(int id) 
	{
		currentFrame = id;
		UpdateFrames();
	}
	
	private void UpdateFrames() 
	{
		for (int i = 0; i<transform.childCount; i++) 
		{
			transform.GetChild(i).gameObject.SetActive(false);
		}
		transform.GetChild(currentFrame).gameObject.SetActive(true);
	}
}
