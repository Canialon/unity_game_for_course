using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tru_move_the_hero : MonoBehaviour
{
    Vector3 movevector = Vector3.zero;
    CharacterController charactercontroller;


    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

    // for coin
    public int bottle = 0;


    private void Start()
    {
        charactercontroller = GetComponent<CharacterController>();

    }


    void Update()
    {
                movevector.x = Input.GetAxis("Horizontal") * moveSpeed;
        movevector.z = Input.GetAxis("Vertical") * moveSpeed;

                if (charactercontroller.isGrounded && Input.GetButton("Jump"))
            movevector.y = jumpSpeed;

        movevector.y -= gravity * Time.deltaTime;

            charactercontroller.Move(movevector * Time.deltaTime);

    }



    //for coin
    private void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 220, 60), "Bottles: " + bottle);
    }




}
