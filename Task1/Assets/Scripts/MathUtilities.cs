using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace UniqueStudioTasks
{
    namespace Task1
    {
        class MathUtilities
        {
            public static float CalculateAngles(Vector3 a)
            {
                return Mathf.Atan2(a.y,a.x);
            }
        }
    }
}