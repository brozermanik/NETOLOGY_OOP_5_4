using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Netology_5_4
{
    public class ProjectileData : MonoBehaviour
    {
        [SerializeField] public float Damage;
        [SerializeField] public float ProjectileSpeed;
        [SerializeField] public float Duration;
        public enum ProjectileType : byte
        {
            Bullet,
            Arrow,
            MagicMissile
        }
    }
}
