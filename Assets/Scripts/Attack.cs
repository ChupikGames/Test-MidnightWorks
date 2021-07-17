using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject AI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Attack");
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            AI.GetComponent<Animator>().SetTrigger("Move");
        }
    }
}
