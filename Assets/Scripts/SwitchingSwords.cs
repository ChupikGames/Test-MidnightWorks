using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchingSwords : MonoBehaviour
{
    private Inventory inventory;

    public SwordClass[] swords;
    public SetAttackType attackType;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        attackType = GetComponent<SetAttackType>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            inventory.selectedSword = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            inventory.selectedSword = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            inventory.selectedSword = 2;
        }
        PickedWeapon();
    }

    void PickedWeapon()
    {
       
        if (inventory.selectedSword != -1)
        {
            for (int i = 0; i < inventory.swords.Length; i++)
            {
                if (i == inventory.selectedSword)
                {
                    inventory.swords[i].gameObject.SetActive(true);
                    for (int j = 0; j < swords.Length; j++)
                    {
                        if (swords[j].swordSkin == inventory.swords[i])
                        {
                            attackType.Set(swords[j].index);
                            Debug.Log(swords[j].index);
                        }
                    }

                }
                else
                {
                    inventory.swords[i].gameObject.SetActive(false);
                }
            }
        }
        
           
        
    }
}
