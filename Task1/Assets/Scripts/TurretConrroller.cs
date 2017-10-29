using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniqueStudioTasks.Task1;

public class TurretConrroller : MonoBehaviour {

    public Vector3 CurrentMousePosition;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(CurrentMousePosition);
        CurrentMousePosition = new Vector3(Input.mousePosition.x ,
            Input.mousePosition.y - Screen.height / 2,
            Input.mousePosition.z);
        float RotateAngle = Mathf.Rad2Deg *
            MathUtilities.CalculateAngles(CurrentMousePosition);
        GetComponent<Transform>().rotation =
            Quaternion.Euler(0, 0, RotateAngle
            );
    }
}
