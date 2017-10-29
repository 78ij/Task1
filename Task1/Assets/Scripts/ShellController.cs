using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellController : MonoBehaviour
{
    public float shellspeed;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2( shellspeed *
            (GetComponent<Transform>().position.x + 11.24f),
            shellspeed *
            GetComponent<Transform>().position.y
            );
    }
	
	// Update is called once per frame
	void Update () {

    }
}
