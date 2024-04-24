using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuizAdder : MonoBehaviour
{
	
	[SerializeField] TextAsset quizContentText;
	[SerializeField] List<Quiz> quizList;
	
	[SerializeField] TextAsset factContentText;
	[SerializeField] List<GameObject> factList;

    void Start()
	{ 
		StartCoroutine("AddQuiz");
		StartCoroutine("AddFacts");
	}
    
	private IEnumerator AddQuiz() 
	{
		yield return new WaitForSeconds(0.01f);
		
		string content = quizContentText.text;
		string current = "";
		string lineEnd = "\n";
		string tab = "\t";
		int content_n = 0;
	    
		int j = 0;
	    
			for (int i = 0; i<content.Length; i++) 
			{	
				if (content[i] == lineEnd[0]) 
				{    			
					quizList[j].quizType = int.Parse(current);
		    	
					//quizList[j].transform.parent.parent.gameObject.SetActive(false);
		    	
					content_n = 0;
					current = "";
					j += 1;
					
					if (j>=quizList.Count) yield break;
				}
				else if (content[i] == tab[0]) 
				{
					content_n += 1;
					switch (content_n) 
					{
					case 1:
						quizList[j].QuestionText.text = current;
						break;
					case 2:
						quizList[j].AnswerButtons.transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = current;
						break;
					case 3:
						quizList[j].AnswerButtons.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>().text = current;
						break;
					case 4:
						quizList[j].AnswerButtons.transform.GetChild(2).GetComponentInChildren<TextMeshProUGUI>().text = current;
						break;
					case 5:
						quizList[j].correctId = int.Parse(current) - 1;
						break;
					case 6:
						quizList[j].AnswerText.GetComponent<TextMeshProUGUI>().text = current;
						break;
					}
					
					current = "";
				}
				else
				{
					current = current + content[i];		
				}
		}
			
		for (int i=0;i<quizList.Count;i++) 
		{
			quizList[i].transform.parent.parent.gameObject.SetActive(false);	
		}
	}
			
			
			    
	private IEnumerator AddFacts() 
	{
		yield return new WaitForSeconds(0.2f);
		
		string content = factContentText.text;
		string current = "";
		string lineEnd = "\n";
		string tab = "\t";
		int content_n = 0;
	    
		int j = 0;
	    
		for (int i = 0; i<content.Length; i++) 
		{	
			if (content[i] == lineEnd[0]) 
			{    			
				
				factList[j].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = current;
				
				content_n = 0;
				current = "";
				j += 1;
					
				if (j>=factList.Count) yield break;
			}
			else if (content[i] == tab[0]) 
			{
				content_n += 1;
				switch (content_n) 
				{
				case 1:
					factList[j].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = current;
					break;
				}
					
				current = "";
			}
			else
			{
				current = current + content[i];		
			}
			factList[j].transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = current;
		}
			
		for (int i=0;i<factList.Count;i++) 
		{
			factList[i].transform.parent.parent.gameObject.SetActive(false);	
		}
		
	}		
}
