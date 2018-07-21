using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {
	public int power;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnParticleCollision(GameObject other){
		Debug.Log(other.tag);
		if(other.tag == "target"){
			other.GetComponent<Hit>().reduceHP(power);
			
		}
	}	
}
