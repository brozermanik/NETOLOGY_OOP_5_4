using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileData : MonoBehaviour
{
    [SerializeField]
    public float Damage;
    [SerializeField]
    public float ProjectileSpeed;
    [SerializeField]
    public float Duration;

    public enum ProjectileType
    {
        Bullet,
        Arrow,
        MagicMissile
    }
}
