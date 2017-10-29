using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace UniqueStudioTasks
{
    namespace Task1
    {
        public class PlanePool : MonoBehaviour
        {
            public string CurrentType;
            List<GameObject> pool = new List<GameObject>();
            public PlanePool() { }
            private static PlanePool instance; //Singleton pattern
            public static PlanePool GetInstance()
            {
                if(instance == null)
                {
                    instance = new GameObject("PlanePool")
                        .AddComponent<PlanePool>();
                }
                return instance;
            }
            public GameObject Instantiate(string type)
            {
                CurrentType = type;
                if(pool.Find(SearchForType) == null)
                {
                    return Factories.CreatePlane(type);
                }
                else
                {
                    GameObject temp =  pool.Find(SearchForType);
                    temp.SetActive(true);
                    pool.Remove(temp);
                    return temp;
                }
            }
            public void Disable(GameObject plane)
            {
                plane.SetActive(false);
                pool.Add(plane);
            }
            public bool SearchForType(GameObject plane)
            {
                if (plane.tag == CurrentType)
                    return true;
                else
                    return false;
            }
        }
    }
}