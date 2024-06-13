using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager player_atm;
    public AttributesManager enemy_atm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            player_atm.DealDamage(enemy_atm.gameObject);
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            enemy_atm.DealDamage(player_atm.gameObject);
        }
    }
}
