using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_audo : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip characterIsMove;
    //bool q ;
    

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<qq>())
        {
            aS.PlayOneShot(characterIsMove);
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
