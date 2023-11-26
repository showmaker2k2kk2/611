using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Enemy",menuName ="Enemy/createnewEnemy")]
public class EnemyIndex : ScriptableObject
{
    [Header("Comnfiguration")]
    public int StartHealth=100;
    public int curentHealth;
    public float  speedstart;
    public float AttackRange;
    public int DameMeelee;



}
