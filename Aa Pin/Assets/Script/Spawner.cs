using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject pinPrefab;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown("Fire1")){

			spawn();
		}
	}
	void spawn(){
	
		Instantiate(pinPrefab, transform.position, transform.rotation);
	}
}
