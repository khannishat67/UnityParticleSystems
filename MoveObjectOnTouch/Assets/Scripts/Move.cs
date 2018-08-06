using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y  < -8.5f){
			gameObject.transform.position = new Vector3(gameObject.transform.position.x,4.0f,0.0f);
			
			
		}
		else{
			transform.Translate(0,-Time.deltaTime*speed,0);
		}
			
	}
}
