using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileData : MonoBehaviour
{
    public class BaseProjectile
    {
        [SerializeField] public static float Damage;
        [SerializeField] public static float ProjectileSpeed;
        [SerializeField] public static float Duration;

        public enum ProjectileType
        {
            Bullet,
            Arrow,
            MagicMissile
        }
    }
}
