using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UniqueStudioTasks
{
    namespace Task1
    {
        class StrongHealthChangedObject : MonoBehaviour
        {
            public List<GameObject> planes = new List<GameObject>();
            public static StrongHealthChangedObject instance;
            public int health = 5;
            public static StrongHealthChangedObject GetInstance()
            {
                if(instance == null)
                {
                    instance = new GameObject("StrongHealth").AddComponent<StrongHealthChangedObject>();
                    return instance;
                }
                return instance;
            }
            void Update()
            {
                foreach(var plane in planes)
                {
                    plane.GetComponent<StrongPlaneController>().maxhealth = health;
                }
            }
        }
    }
}
