using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    [SerializeField] public float Health;
    [SerializeField] public float MoveSpeed;
    [SerializeField] public float AttackSpeed;
    [SerializeField] public float AttackRange;
    
    public enum EnemyType
    {
        Human,
        Orc,
        Undead,
        Dragon
    }
}
