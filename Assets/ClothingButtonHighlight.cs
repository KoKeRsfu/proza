using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClothingButtonHighlight : MonoBehaviour
{

	[SerializeField] TMP_FontAsset FontBlack;
	[SerializeField] TMP_FontAsset FontWhite;

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
	public void EnableHighlight() 
	{
		this.GetComponentInParent<ClothingPanel>().DisableHighlightAll();
		this.GetComponentInParent<ClothingPanel>().ChangeText(transform.GetSiblingIndex());
		
		this.GetComponent<Image>().enabled = true;
		this.GetComponentInChildren<TextMeshProUGUI>().font = FontBlack;
		this.GetComponentInChildren<TextMeshProUGUI>().UpdateFontAsset();
	}
	
	public void DisableHighlight() 
	{
		this.GetComponent<Image>().enabled = false;
		this.GetComponentInChildren<TextMeshProUGUI>().font = FontWhite;
		this.GetComponentInChildren<TextMeshProUGUI>().UpdateFontAsset();	
	}
}
