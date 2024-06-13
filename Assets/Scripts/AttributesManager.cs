using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttributesManager : MonoBehaviour
{
    public int health;
    public int attack;
    public float critDamage = 1.5f;
    public float critChance = 0.5f;
    public void TakeDamage(int amount)
    {
        //giảm máu nhưng phụ thuộc thêm vào giáp
        health -= amount;
        DamagePopUpGenerator.current.CreatePopUp(transform.position, amount.ToString());

        if (gameObject.CompareTag("Enemy"))
        {
            Slider slider = gameObject.transform.GetChild(3).transform.GetChild(0).transform.GetComponent<Slider>();
            slider.value = health;

            if (health <= 0)
            {
                EnemyDie();
            }
        }
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if(atm!=null)
        {   
            float totalDamage = attack;
            if(Random.Range(0f, 1f) < critChance)
                totalDamage *= critDamage;

            atm.TakeDamage((int)totalDamage);
        }
    }
    public void EnemyDie()
    {
        Debug.Log("Ke thu die");

        Animator ani = gameObject.transform.GetChild(0).GetComponent<Animator>();

        ani.SetBool("isDead", true);

        GameObject canvas=gameObject.transform.GetChild(1).gameObject;
        canvas.SetActive(false);

        Invoke("DeActiveTpose", 2f);
        Invoke("ActiveGem", 2f);
        Destroy(gameObject, 7f);
    }
    void ActiveGem()
    {
        GameObject gem = gameObject.transform.GetChild(1).gameObject;
        gem.SetActive(true);
    }
    void DeActiveTpose()
    {
        GameObject enemytpose = gameObject.transform.GetChild(0).gameObject;
        enemytpose.SetActive(false);
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


// GetChild(0) la enemytpose, GetChild(1) la gem, GetChild(2) la capsule, GetChild(3) la canvas
