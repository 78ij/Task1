using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;

public class StrongPlaneController : PlaneBase, IEnemyPlane
{
    private string _type = "strongplane";
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
        Health = 5;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
    }


    // Update is called once per frame
    public override void Update()
    {
        Destroy();

    }
    public void Destroy()
    {
        if (Health == 0)
        {
            PlanePool.GetInstance().Disable(this.gameObject);
            GameController controller = GameObject.FindGameObjectWithTag("GameController")
                  .GetComponent<GameController>();
            controller.score++;
        }
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
        Health = 5;
        GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
    }
}
