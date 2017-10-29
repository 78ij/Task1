using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;
public class NormalPlaneController : PlaneBase,IEnemyPlane{
    private string _type = "normalplane";
    public  string Type {
        get {
            return _type;
        }
    }
    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
	// Use this for initialization
	public override void  Start () {
		
	}

    // Update is called once per frame
    public override void Update () {
		
	}
    public void Destroy()
    {
        Destroy(this.gameObject);
        Destroy(this);
    }
    public void Fire()
    {

    }
}
