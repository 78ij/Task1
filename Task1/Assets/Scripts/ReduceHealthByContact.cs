﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;
public class ReduceHealthByContact : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "normalplane"
            || other.tag == "strongplane"
            || other.tag == "quickplane")
        {
            other.SendMessage("GotHit",null, SendMessageOptions.DontRequireReceiver);
            Destroy(this.gameObject);
            Destroy(this);
        }
    }
}
