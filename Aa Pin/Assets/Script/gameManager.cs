using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

	private bool gameHasEnded = false;
	public Rotator rotator;
	public Spawner spawner;
	public Animator animator;

	public void endGame(){

		if (gameHasEnded) 
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger ("EndGame");

		gameHasEnded = true;

	}

	public void RestartLevel(){
	
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	
	}
}