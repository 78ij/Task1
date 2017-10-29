using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace UniqueStudioTasks
{
    namespace Task1 {
        class Factories
        {

            public static GameObject CreatePlane(string type)
            {
                switch (type)
                {
                    case "normalplane":
                        return Resources.Load("Prefabs\\normalplane") as GameObject;
                        break;
                }
                return null;
            }
        }
    }
}
