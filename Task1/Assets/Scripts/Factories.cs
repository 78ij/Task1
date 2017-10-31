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
                        return Instantiate(Resources.Load(type,typeof(GameObject)) as GameObject,
                            position,
                            Quaternion.Euler(new Vector3(0 ,0 ,90)));
                        return null;
            }
        }
    }
}