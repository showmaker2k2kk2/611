using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Tgun 
{

    public enum ShootMode
    {
        Click,
        Hold
    }


    public string Name;
    public ShootMode shootMode;
    public int Dame;
    public int ScreenShakingForce;// ?? rung c?a màn hình
    public float speedFire;
    public int MagazineSize = 27;//kích th??c b?ng ??n, số l??ng đạn
    public GameObject projectile;
    public Transform Shootpoint;
    public GameObject Weaponprefabs;
}
