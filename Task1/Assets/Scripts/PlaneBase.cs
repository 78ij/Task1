using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniqueStudioTasks
{
    namespace Task1
    {
        public abstract class PlaneBase : MonoBehaviour
        {
            public abstract void Start();
            public abstract void Update();
            public abstract int Health { get; set; }
        }
    }
}
