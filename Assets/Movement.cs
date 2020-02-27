using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    Vector3 initPos;
    public Transform[] hazard;
    AudioSource audPlayer;
    public AudioClip moveClip, hazardClip, goodClip;
    public Transform good;


    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;
        audPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
        //MOVEMENT CODE
    {   if(Input.GetKeyDown(KeyCode.A))
        {player.transform.position += new Vector3(0, 0, 1); audPlayer.PlayOneShot(moveClip); }
        if(Input.GetKeyDown(KeyCode.W))
        {player.transform.position += new Vector3(1,0,0); audPlayer.PlayOneShot(moveClip); }
        if(Input.GetKeyDown(KeyCode.S))
        {player.transform.position += new Vector3(-1,0,0); audPlayer.PlayOneShot(moveClip); }
        if(Input.GetKeyDown(KeyCode.D))
        {player.transform.position += new Vector3(0,0,-1); audPlayer.PlayOneShot(moveClip); }

        //HAZARD CODE
        for (int i=0; i<hazard.Length; i++)
        if(hazard[i].position == player.transform.position)
        {player.transform.position = initPos; audPlayer.PlayOneShot(hazardClip); }

      

    
}
}
