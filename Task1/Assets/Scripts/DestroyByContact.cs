using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;
public class DestroyByContact : MonoBehaviour {

    private GameController gamecontroller;
	// Use this for initialization
	void Start () {
        GameObject gamecontrollerobject = GameObject.FindGameObjectWithTag("GameController");
        gamecontroller = gamecontrollerobject.GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "shell") {
            Destroy(other.gameObject);
            Destroy(other);
        }
        if (other.tag == "normalplane"
    || other.tag == "strongplane"
    || other.tag == "quickplane")
        {
            PlanePool.GetInstance().Disable(other.gameObject);
            //if(GetComponent<Collider2D>().tag == "left")
                gamecontroller.Hurt();
        }

    }
}
