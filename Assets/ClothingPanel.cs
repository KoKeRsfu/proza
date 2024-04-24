using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClothingPanel : MonoBehaviour
{
	public List<string> summerDescriptions;
	public List<string> winterDescriptions;
	
	public List<GameObject> summerClothing;
	public List<GameObject> winterClothing;
	
	[SerializeField] TextMeshProUGUI summerName;
	[SerializeField] TextMeshProUGUI summerDescription;
	[SerializeField] TextMeshProUGUI winterName;
	[SerializeField] TextMeshProUGUI winterDescription;
	
	private Transform summerPanel;
	private Transform winterPanel;
	private Transform soldiers;
	
	[SerializeField] Image summerButton;
	[SerializeField] Image winterButton;
	
    void Start()
	{
		soldiers = this.transform.GetChild(1);
		summerPanel = this.transform.GetChild(3);
		winterPanel = this.transform.GetChild(4);
    }
    
	public void SummerButton() 
	{		
		for (int i=0;i<summerClothing.Count;i++) 
	{
		summerClothing[i].SetActive(false);
	}
		for (int i=0;i<winterClothing.Count;i++) 
		{
			winterClothing[i].SetActive(false);
		}
		
		summerName.gameObject.SetActive(true);
		summerDescription.gameObject.SetActive(true);
		winterName.gameObject.SetActive(false);
		winterDescription.gameObject.SetActive(false);
		
		summerPanel.gameObject.SetActive(true);
		winterPanel.gameObject.SetActive(false);
		
		summerButton.sprite = Resources.Load<Sprite>("CnK/ClothingFrames/summerButton_1");
		winterButton.sprite = Resources.Load<Sprite>("CnK/ClothingFrames/winterButton_0");
		
		for (int i=0;i<soldiers.childCount;i++) 
		{
			soldiers.GetChild(i).gameObject.SetActive(false);
		}
		soldiers.GetChild(1).gameObject.SetActive(true);
	}
	
	public void WinterButton() 
	{
		for (int i=0;i<summerClothing.Count;i++) 
		{
			summerClothing[i].SetActive(false);
		}
		for (int i=0;i<winterClothing.Count;i++) 
		{
			winterClothing[i].SetActive(false);
		}
		
		summerName.gameObject.SetActive(false);
		summerDescription.gameObject.SetActive(false);
		winterName.gameObject.SetActive(true);
		winterDescription.gameObject.SetActive(true);
		
		summerPanel.gameObject.SetActive(false);
		winterPanel.gameObject.SetActive(true);
		
		summerButton.sprite = Resources.Load<Sprite>("CnK/ClothingFrames/summerButton_0");
		winterButton.sprite = Resources.Load<Sprite>("CnK/ClothingFrames/winterButton_1");
		
		for (int i=0;i<soldiers.childCount;i++) 
		{
			soldiers.GetChild(i).gameObject.SetActive(false);
		}
		soldiers.GetChild(2).gameObject.SetActive(true);
	}
    
	public void DisableHighlightAll() 
	{
		if (summerPanel.gameObject.active) 
		{
			for (int i=0;i<summerPanel.childCount;i++) 
			{
				summerPanel.GetChild(i).GetComponent<ClothingButtonHighlight>().DisableHighlight();
			}		
		}
		else 
		{
			for (int i=0;i<winterPanel.childCount;i++) 
			{
				winterPanel.GetChild(i).GetComponent<ClothingButtonHighlight>().DisableHighlight();
			}
		}
	}
	
	public void ChangeText(int n)
	{
		for (int i=0;i<summerClothing.Count;i++) 
		{
			summerClothing[i].SetActive(false);
		}
		for (int i=0;i<winterClothing.Count;i++) 
		{
			winterClothing[i].SetActive(false);
		}
		
		if (summerPanel.gameObject.active)
		{
			summerName.text = summerPanel.GetChild(n).GetComponentInChildren<TextMeshProUGUI>().text;
			summerDescription.text = summerDescriptions[n];
			summerClothing[n].SetActive(true);
		}
		else
		{
			winterName.text = winterPanel.GetChild(n).GetComponentInChildren<TextMeshProUGUI>().text;
			winterDescription.text = winterDescriptions[n];
			winterClothing[n].SetActive(true);
		}
	}
}
