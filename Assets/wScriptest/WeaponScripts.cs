using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScripts : MonoBehaviour
{
   public WeaponState states;// mỗi khẩu súng sẽ có 1 trang thái riêng;


    void Start()
    {
        AnimateWeaponOnGround();
    }

    // Update is called once per frame
    void Update()
    {
        //AnimateWeaponOnGround();
    }
    public void AnimateWeaponOnGround()
    {
        transform.localScale = new Vector3(2, 2, 2);
        //transform.rotation = Quaternion.Euler(0, 0, 90);

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Gun>())
        {
            if(other.GetComponent<Gun>().vu_khi_tren_tay.Count<2)
            {
                other.GetComponent<Gun>().AddWeapon(this.gameObject); //truy cập đến phươg thức thêm vũ khí của lớp Gun
            }    
        }
        
    }
}
