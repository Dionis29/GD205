using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    Rigidbody rb;
    public GameObject victim;

    // Start is called before the first frame update
    void Start()
    { rb = GetComponent<Rigidbody>(); }

    // Update is called once per frame
    void Update()
    {
  



    }

    void OnCollisionEnter(Collision MycCollision)
    {
        if (MycCollision.gameObject == victim)
        { Destroy(victim); }
        print("lol collision");
    }
}

