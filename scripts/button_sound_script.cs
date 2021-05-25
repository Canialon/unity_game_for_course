using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_sound_script : MonoBehaviour
{
    public AudioSource aS;
    public AudioClip sound;
    public void OnMouseEnter()
    {
        aS.PlayOneShot(sound);
    }

}
