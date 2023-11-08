using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class WeaponState:Ishot// tạo ra 1 biến và cung cấp các biến này cho các loại vũ khí mà cần dùn
{
    public string Name;
    public int Dame;
    public int ScreenShakingForce;// ?? rung c?a màn hình
    public float speedFire;
    public int MagazineSize=27;//kích th??c b?ng ??n, số l??ng đạn
    public GameObject projectile;
    public Transform Shootpoint;
    public GameObject Weaponprefabs;

    public void shoot(int Dame)
    {
       
    }

    //public Sprite ImageWeapon;
    //public AudioClip WeaponShotsound;
    //public AudioClip WeaponpickUpSound;
}
