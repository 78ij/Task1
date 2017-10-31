using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace UniqueStudioTasks
{
    namespace Task1
    {
        public abstract class PlaneBase : MonoBehaviour
        {
            public abstract void Start();
            public abstract void Update();
        }

        public interface IEnemyPlane
        {
            int Health { get; set; }
            void Destroy();
            void Fire();
            void GotHit();
            void Revive();
        }
        
    }
}