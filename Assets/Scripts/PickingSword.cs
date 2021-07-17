using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickingSword : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemSlot;
    public GameObject swordHolder;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                { 
                    inventory.isFull[i] = true; 
                    Instantiate(itemSlot, inventory.slots[i].transform, false); 
                    Destroy(gameObject);
                    inventory.swords[i] = swordHolder;
                    inventory.selectedSword = i;
                    break;
                }
            }
        }

    }
}
