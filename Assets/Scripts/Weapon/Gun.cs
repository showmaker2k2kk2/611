using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private WeaponState Currentweapon=new WeaponState();

    public List<WeaponState> vu_khi_tren_tay;// chứa thông tin vũ khí mà người chơi cầm trên tay
    public Transform tay;// khi nhặt vũ khí thì dặt tay người chơi làm cha  của vũ khí, đặt vị trí của vũ khí là tay người chơi
    private int CurrentIndexGun = 0;

    public float fireRate = 0.1f; // Tần suất bắn (thời gian giữa các viên đạn)
    private float nextFire = 0.0f;



    int so_luong_dan_da_ban = 0;//được kiểm tra dựa trên số lương đạn của tuõng vũ khí        Weaponstate.  MagazineSize ,và đẻ nạp lại đạn khi về 0
    bool dangnapdan=false;







    public Transform pointshoot;
    //public GameObject aduu;
    public ParticleSystem fx;
    Bullet bulet;

    Rigidbody rb;
    Animator anim;


    public float speed;


    private void Awake()
    { 
       anim= GetComponent<Animator>();
      
    }


    void Start()
    {
        
        Currentweapon = null;
        CurrentIndexGun = 0;

    }
    void Update()
    {

        if (Currentweapon != null)
        {
            if (Currentweapon.shootMode == WeaponState.ShootMode.Hold)
            {
                if (Input.GetMouseButton(0) && Time.time > nextFire)

                {
                    shootGattling();
                    nextFire = Time.time + fireRate;
                    
                    anim.SetBool("shotsigle", true);

                }
                else { anim.SetBool("shotsigle", false); }

            }
            else if (Currentweapon.shootMode == WeaponState.ShootMode.Click)
            {

                if (Input.GetMouseButtonDown(0))
                {
                    
                    shoot();
                    //bulet.flashFx.Play(); 
                    anim.SetBool("shotsigle", true);

                }
                else { anim.SetBool("shotsigle", false); }

            }
        }
    
        if (Input.GetKeyDown(KeyCode.E))
        {
            changeWeapon();
        }

    }

    void shoot()
    {
        so_luong_dan_da_ban += 1;
        GameObject bullet = Instantiate(Currentweapon.projectile, Currentweapon.Shootpoint.transform.position, transform.rotation);
        Bullet bu = bullet.GetComponent<Bullet>();
        fx.Play();
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        //bu.Adfore();
        Destroy(bullet, 4);
    }
    void  shootGattling()
    {
        GameObject bullet = Instantiate(Currentweapon.projectile, Currentweapon.Shootpoint.transform.position, transform.rotation);    
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        Destroy(bullet, 4);
    }
     public  void AddWeapon(GameObject weaponpickup)
    {   
        if(vu_khi_tren_tay.Count<3)
        {
            weaponpickup.SetActive(false);
            vu_khi_tren_tay.Add(weaponpickup.GetComponent<WeaponScripts>().states);
            weaponpickup.transform.SetParent(tay);
            weaponpickup.transform.localScale = Vector3.one;
            weaponpickup.transform.localPosition = Vector3.zero;
            weaponpickup.transform.localRotation = Quaternion.Euler(0, 90, 90);
        }
        if (Currentweapon == null)
        {
            Currentweapon = weaponpickup.GetComponent<WeaponScripts>().states;
            weaponpickup.SetActive(true);
            
        }

       
    }       
    IEnumerator napdan()
    {
        yield return new  WaitForSeconds(1);
        dangnapdan = false;
        so_luong_dan_da_ban= 0;    
    }
   public  void changeWeapon()
    {

        if (vu_khi_tren_tay.Count > 1)
        {

            Currentweapon.Weaponprefabs.SetActive(false);

            CurrentIndexGun = (CurrentIndexGun + 1) % vu_khi_tren_tay.Count;
            Currentweapon = vu_khi_tren_tay[CurrentIndexGun];
            Currentweapon.Weaponprefabs.SetActive(true);
            
        }
        else if (vu_khi_tren_tay.Count == 1)
        {
            Currentweapon = vu_khi_tren_tay[0];
            Currentweapon.Weaponprefabs.SetActive(true);
        }

    }

}    

