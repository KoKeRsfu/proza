using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasRenderSwitch : MonoBehaviour
{
    void Start()
    {
	    this.gameObject.GetComponent<Canvas>().renderMode = RenderMode.WorldSpace;
    }
    
	public void ResetCameraPosition()
	{
		Camera.main.gameObject.transform.position = new Vector3(0,0,0);
	}
}
