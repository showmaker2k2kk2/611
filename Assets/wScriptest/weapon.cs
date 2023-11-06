using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newWeapon", menuName = "weapon/creaweapon")]
public class weapon : ScriptableObject
{
    [Header("Comnfigurattion")]
    public float Projectitlespeed = 5000;
    public int ReadTime;

    public string Name;
    public int Dame;
    public int ScreenShakingForce;// độ rung của màn hình
    public float speedFire;
    public int MagazineSize;//kích thước băng đạn, số lượng đạn
    public GameObject projectile;
    public Transform Shootpoint;
    public GameObject Weaponprefabs;
    public Sprite ImageWeapon;
    public AudioClip WeaponShotsound;
    public AudioClip WeaponpickUpSound;


}
