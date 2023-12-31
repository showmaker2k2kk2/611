﻿using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class WeaponState// tạo ra 1 biến và cung cấp các biến này cho các loại vũ khí mà cần dùn
{

    public enum weapontype
    {
       
        Bazoka,
        GattlingGun,
        ShotGun
    }

    public enum ShootMode
    {
        Click,
        Hold
    }

    public weapontype Weapontype;     
    public string Name;
    public ShootMode shootMode; 
    public int Dame;
    public int ScreenShakingForce;// ?? rung c?a màn hình
    public float speedFire;
    public int MagazineSize=27;//kích th??c b?ng ??n, số l??ng đạn
    public GameObject projectile;
    public Transform Shootpoint;
    public GameObject Weaponprefabs;

    [SerializeField] public ParticleSystem Flash;
    //public Transform PointGattling;
    //public Transform PointBazoka;
    
    //[SerializeField] public ParticleSystem Projectitle;
    //[SerializeField] public ParticleSystem Hit;

    //public Sprite ImageWeapon;
    //public AudioClip WeaponShotsound;
    //public AudioClip WeaponpickUpSound;
}
