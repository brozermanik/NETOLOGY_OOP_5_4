using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileData : MonoBehaviour
{
    // Start is called before the first frame update
    [Serializable]
    public struct BasicProjectile
    {
        public float Damage;
        public float Speed;
        public float Duration;
        public enum Type{bullet,arrow,magic};
    }

    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * 5;
    }
}
