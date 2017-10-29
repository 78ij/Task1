using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UniqueStudioTasks
{
    namespace Task1 {
        class Factories : MonoBehaviour
        {

            public static GameObject CreatePlane(string type,Vector3 position)
            {
                switch (type)
                {
                    case "normalplane":
                        return Instantiate(Resources.Load("normalplane",typeof(GameObject)) as GameObject,
                            position,
                            Quaternion.Euler(new Vector3(0 ,0 ,90)));
                    case "strongplane":
                        return Instantiate(Resources.Load("strongplane", typeof(GameObject)) as GameObject,
                            position,
                            Quaternion.Euler(new Vector3(0, 0, 90)));
                    case "quickplane":
                        return Instantiate(Resources.Load("quickplane", typeof(GameObject)) as GameObject,
                            position,
                            Quaternion.Euler(new Vector3(0, 0, 90)));
                }
                return null;
            }
        }
    }
}