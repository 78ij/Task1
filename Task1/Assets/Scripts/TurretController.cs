using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;

public class TurretController : MonoBehaviour {
    public float FireRate;
    private float NextFire;
    public Vector3 CurrentMousePosition;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        CurrentMousePosition = new Vector3(Input.mousePosition.x ,
            Input.mousePosition.y - Screen.height / 2,
            Input.mousePosition.z);
        float RotateAngle = Mathf.Rad2Deg *
            MathUtilities.CalculateAngles(CurrentMousePosition);
        GetComponent<Transform>().rotation =
            Quaternion.Euler(0, 0, RotateAngle
            );

        if (Input.GetButton("Fire1") && Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;
            Vector3 shellposition = new Vector3(
                -11
                + GetComponent<BoxCollider2D>().size.x * Mathf.Cos(RotateAngle / Mathf.Rad2Deg),
                0
                + GetComponent<BoxCollider2D>().size.x * Mathf.Sin(RotateAngle / Mathf.Rad2Deg),
                -1);
            Instantiate(Resources.Load("shell",typeof(GameObject)) as GameObject,
                shellposition,
                GetComponent<Transform>().rotation
                );
        }
    }
}
