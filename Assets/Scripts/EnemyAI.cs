using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float seeDistance = 15f;
    public float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
                gameObject.GetComponent<Animator>().SetBool("Move", true);

        }
        else
        gameObject.GetComponent<Animator>().SetBool("Move", false);
    }

}
