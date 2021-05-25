using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_to_level : MonoBehaviour
{

        public AudioSource aS;
        public AudioClip dooIsOpen;


    void OnMouseDown()
    {
        SceneManager.LoadScene("LevelScene");
        Debug.Log("Go to level");
    }

    private void OnMouseEnter()
    {
        transform.Rotate(0, 0, -50);

        //soubd
        aS.PlayOneShot(dooIsOpen);

    }
    private void OnMouseExit()
    {
        transform.Rotate(0, 0, 50);
    }


}
