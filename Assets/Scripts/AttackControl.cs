using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackControl : MonoBehaviour
{
    Animator anim;
    private string h ="Horizontal";
    private string v ="Vertical";
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Input.GetAxis(h)!=0 ||Input.GetAxis(v)!=0)//dang di chuyen
            {
                anim.SetTrigger("SlashMask");
            }
            else//dung yen
            {
                anim.SetTrigger("Slash");
            }
        }
    }
}
