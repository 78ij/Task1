using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;

public class QuickPlaneController : PlaneBase, IEnemyPlane
{
    private string _type = "quickplane";
    public string Type
    {
        get
        {
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
    public override void Start()
    {
        Health = 3;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
    }


    // Update is called once per frame
    public override void Update()
    {
        Destroy();

    }
    public void Destroy()
    {
        if (Health == 0)
            PlanePool.GetInstance().Disable(this.gameObject);
    }
    public void Fire()
    {

    }
    public void GotHit()
    {
        Health--;
        Debug.Log(Health);
    }
    public void Revive()
    {
        Health = 3;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-5, 0);
    }
}
