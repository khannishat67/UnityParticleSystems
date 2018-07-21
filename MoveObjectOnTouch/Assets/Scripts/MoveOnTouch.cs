﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 //Gets the world position of the mouse on the screen        
     Vector2 mousePosition = Camera.main.ScreenToWorldPoint( Input.mousePosition );

    /* //Checks whether the mouse is over the sprite
     bool overSprite = this.GetComponent<SpriteRenderer>().bounds.Contains( mousePosition );

     //If it's over the sprite
     if (overSprite)
     {
         //If we've pressed down on the mouse (or touched on the iphone)
         if (Input.GetButton("Fire1"))
         {
             //Set the position to the mouse position
             this.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                 this.transform.position.y,
                 0.0f);
         }
     }*/
	 float xPos=Mathf.Clamp(mousePosition.x,-2.0f,2.0f);
	 this.transform.position = new Vector3(xPos,this.transform.position.y,0.0f);
	}

}
