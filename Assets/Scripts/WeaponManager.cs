using System.Collections;
using System.Collections.Generic;
using Invector.vCharacterController;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public vThirdPersonController tcp;
    public GameObject weapon;
    public void EnableWeaponCollider(int isEnable)
    {
        var col = weapon.GetComponent<Collider>();
        if (col != null)
        {
            if(isEnable==1)
                col.enabled = true;
            else
                col.enabled = false;
        }
    }

    public void EnableMovement(bool enable)
    {
        /*
        if(enable==false)
        {
            tcp.lockMovement = true;
            tcp.lockRotation = true;
        }
        else
        {
            tcp.lockMovement = false;
            tcp.lockRotation = false;
        }
        */
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
