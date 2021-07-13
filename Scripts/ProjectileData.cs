using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame
{
    // Start is called before the first frame update
    [Serializable]
    public class BasicProjectile
    {
        public float Damage;
        public float Speed;
        public float Duration;
        public enum Type{bullet,arrow,magic};
    }
}
