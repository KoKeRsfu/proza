using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
	[SerializeField] TMP_FontAsset FontBlack;
	[SerializeField] TMP_FontAsset FontWhite;
	
	public int correctId;
	public int quizType;

	public TextMeshProUGUI QuestionText;
	public GameObject AnswerButtons;
	public TextMeshProUGUI CorrectText;
	public GameObject AnswerText;
	

	protected void Awake()
	{
		QuestionText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
		AnswerButtons = transform.GetChild(1).gameObject;
		CorrectText = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
		AnswerText = transform.GetChild(3).gameObject;	
	}
	
	
	public void ResetQuid() 
	{
		for (int i=0;i<3;i++) 
		{
			AnswerButtons.transform.GetChild(i).GetComponent<Image>().color = new Color(1,1,1,1); //белый
			AnswerButtons.transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().font = FontBlack;
			AnswerButtons.transform.GetChild(i).GetComponentInChildren<TextMeshProUGUI>().UpdateFontAsset();
			AnswerButtons.transform.GetChild(i).GetComponent<Button>().interactable = true;
		}
		CorrectText.gameObject.SetActive(false);
		AnswerText.gameObject.SetActive(false);
	}
	
	public void Answer(int id)
	{
		if (id == correctId) 
		{
			AnswerButtons.transform.GetChild(id).GetComponent<Image>().color = new Color(0.42f, 0.91f, 0.62f, 1); //зелёный
			CorrectText.text = "верно";
		}
		else 
		{
			AnswerButtons.transform.GetChild(id).GetComponent<Image>().color = new Color(0.75f, 0.17f, 0.27f, 1); //красный
			AnswerButtons.transform.GetChild(id).GetComponentInChildren<TextMeshProUGUI>().font = FontWhite;
			AnswerButtons.transform.GetChild(id).GetComponentInChildren<TextMeshProUGUI>().UpdateFontAsset();
			CorrectText.text = "правильный ответ:";
		}
		for (int i=0;i<3;i++) 
		{
			AnswerButtons.transform.GetChild(i).GetComponent<Button>().interactable = false;
		}
		CorrectText.gameObject.SetActive(true);
		AnswerText.gameObject.SetActive(true);
	}
	
}
