using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    Vector3 initPos;
    public Transform[] hazard;

    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
        //MOVEMENT CODE
    {   if(Input.GetKeyDown(KeyCode.A))
        {player.transform.position += new Vector3(0, 0, 1); }
        if(Input.GetKeyDown(KeyCode.W))
        {player.transform.position += new Vector3(1,0,0); }
        if(Input.GetKeyDown(KeyCode.S))
        {player.transform.position += new Vector3(-1,0,0);}
        if(Input.GetKeyDown(KeyCode.D))
        {player.transform.position += new Vector3(0,0,-1);}

        //HAZARD CODE
        for (int i=0; i<hazard.Length; i++)
        if(hazard[i].position == player.transform.position)
        {player.transform.position = initPos;}

}
}
