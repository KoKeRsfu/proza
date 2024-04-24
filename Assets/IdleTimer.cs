using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleTimer : MonoBehaviour
{
	
 float idle_lim = 60.0f;
 float last_ui = 0.0f;
 bool idle = false;

 protected void Awake()
 {
	 last_ui = Time.time;
 }

 void FixedUpdate() 
 { 
	 if (Input.anyKeyDown) 
		 {
		 last_ui = Time.time;
		}
	 if ( ( Time.time - last_ui ) > idle_lim ) { 
		 last_ui = Time.time;
		 ReloadScene();
	 } 
 }
 
 public void ReloadScene() 
 {
	 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }
 
}
