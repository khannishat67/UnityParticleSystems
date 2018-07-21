using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	public int hitpoints = 100;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 public void reduceHP(int val){
		if(hitpoints>0){
			hitpoints -=val;
			
		}
			
		else{
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
			//Destroy(gameObject);
	}
	/* void OnCollisionEnter2D(Collision2D other){
		Debug.Log("hua");
		//if(other.gameObject.tag == "bullet")
			reduceHP(10);
	}*/
}
