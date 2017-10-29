using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            (GetComponent<Transform>().position.x + 11.24f),
            
            GetComponent<Transform>().position.y
            );
    }
	
	// Update is called once per frame
	void Update () {

    }
}
