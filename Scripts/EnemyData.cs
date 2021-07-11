using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Netology_5_4
{
    public class EnemyData : MonoBehaviour
    {
        [SerializeField] public float Health;
        [SerializeField] public float MoveSpeed;
        [SerializeField] public float AttackSpeed;
        [SerializeField] public float AttackRange;
        public enum EnemyType : byte
        {
            Human,
            Orc,
            Undead,
            Dragon
        }
    }    
}

