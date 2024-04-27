using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class CameraMove : MonoBehaviour
{
	public float camPos;
	[SerializeField] Transform activeSlide;
	[SerializeField] TextMeshProUGUI slideText;
	
	
	[SerializeField] float xbound1;
	[SerializeField] float xbound2;
	
	private Vector3 Origin;
	private Vector3 Difference;

	[SerializeField] Camera cam;

	private bool drag = false;

	private void LateUpdate()
	{
		if (Input.GetMouseButton(0))
		{
			Difference = (cam.ScreenToWorldPoint(Input.mousePosition)) - cam.transform.position;
			if(drag == false)
			{
				drag = true;
				Origin = cam.ScreenToWorldPoint(Input.mousePosition);
			}

		}
		else
		{
			drag = false;
		}

		if(drag)
		{
			Camera.main.transform.position = Origin - Difference;
			Camera.main.transform.position = new Vector3(
				Mathf.Clamp(Camera.main.transform.position.x, (xbound1 + cam.orthographicSize), (xbound2 - cam.orthographicSize)),
				Mathf.Clamp(Camera.main.transform.position.y, -10 + cam.orthographicSize, 10 - cam.orthographicSize), 0);
			camPos = Camera.main.transform.position.x;
			if (camPos > 17.45f) 
			{
				activeSlide.SetSiblingIndex(3);
				slideText.text = "Битва за реку";
			}
			else 
			{
				activeSlide.SetSiblingIndex(2);
				slideText.text = "Переправа";
			}
		}
	}
	
	// This function is called when the object becomes enabled and active.
	protected void OnEnable()
	{
		camPos = Camera.main.transform.position.x;
		if (camPos > 17.45f) 
		{
			activeSlide.SetSiblingIndex(3);
			slideText.text = "Битва за реку";
		}
		else 
		{
			activeSlide.SetSiblingIndex(2);
			slideText.text = "Переправа";
		}
	}
}
