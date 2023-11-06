using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public WeaponState Currentweapon=new WeaponState();
    public List<WeaponState> vu_khi_tren_tay;// chứa thông tin vũ khí mà người chơi cầm trên tay
    public Transform tay;// khi nhặt vũ khí thì dặt tay người chơi làm cha  của vũ khí, đặt vị trí của vũ khí là tay người chơi
    
    int so_luong_dan_da_ban = 0;//được kiểm tra dựa trên số lương đạn của tuõng vũ khí        Weaponstate.  MagazineSize ,và đẻ nạp lại đạn khi về 0
    bool dangnapdan=false;







    public Transform pointshoot;
    public GameObject aduu;
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

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
            //bulet.flashFx.Play(); 
            anim.SetBool("shotsigle", true);

        }
        else { anim.SetBool("shotsigle", false); }




        //if(so_luong_dan_da_ban>=Currentweapon.MagazineSize)
        //{
        //    dangnapdan = true;
        //    StartCoroutine(napdan());
        //}    
    }
    void shoot()
    {
        so_luong_dan_da_ban += 1;

        GameObject bullet = Instantiate(aduu, pointshoot.transform.position, transform.rotation);
        Bullet bu = bullet.GetComponent<Bullet>();
        fx.Play();
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);

        //bu.Adfore();
        Destroy(bullet, 4);
    }
    public void AddWeapon(GameObject weaponpickup)
    {   
        //if(vu_khi_tren_tay.Count<2)
        //{
            weaponpickup.SetActive(true);
            vu_khi_tren_tay.Add(weaponpickup.GetComponent<WeaponScripts>().states);
            weaponpickup.transform.localScale = new Vector3(1, 1, 1);
            weaponpickup.transform.SetParent(tay);
            weaponpickup.transform.position = new Vector3(0, 0, 0);
           weaponpickup.transform.localRotation = Quaternion.Euler(0, 90, 90);
        //} 
        //if(Currentweapon==null)
        //{
        //    Currentweapon=weaponpickup.GetComponent<WeaponScripts>().states;
        //    weaponpickup.SetActive(true);
        //}    

    }   
    IEnumerator napdan()
    {
        yield return new  WaitForSeconds(1);
        dangnapdan = false;
        so_luong_dan_da_ban= 0;

    }    
}
