using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterMovement : MonoBehaviour
{
    public GameObject HUNTER;
    Vector3 initPos;

    Transform cameraT;

    // Start is called before the first frame update
    void Start()
    {
        initPos = HUNTER.transform.position;
        cameraT = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.W))
        { HUNTER.transform.position += new Vector3(1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.S))
        { HUNTER.transform.position += new Vector3(-1, 0, 0); }
        if (Input.GetKeyDown(KeyCode.A))
        { HUNTER.transform.position += new Vector3(0, 0, 1); }
        if (Input.GetKeyDown(KeyCode.D))
        { HUNTER.transform.position += new Vector3(0, 0, -1); }



    }
}
