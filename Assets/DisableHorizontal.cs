using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableHorizontal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


	// This function is called when the object becomes enabled and active.
	protected void OnEnable()
	{
		StartCoroutine("Disable");
	}
	
    // Update is called once per frame
    void Update()
    {
        
    }
    
	IEnumerator Disable()
	{
		this.GetComponent<ScrollRect>().horizontal = true;
		yield return new WaitForSeconds(0.1f);
		this.GetComponent<ScrollRect>().horizontal = false;
	}
}
