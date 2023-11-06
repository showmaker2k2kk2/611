using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="player state",menuName ="State/CreateStatePlayer")]
public class PlayerState : ScriptableObject
{

    [Header("comnfiguration")]
    public int StartHealth=100;
    public float speed;


}
