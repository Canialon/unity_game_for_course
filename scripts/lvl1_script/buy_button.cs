using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy_button : MonoBehaviour
{
    public GameObject bottle2;
    public tru_move_the_hero bottle3;

    private void Start()
    {
        bottle3 = bottle2.GetComponent<tru_move_the_hero>();

    }



    public void BuyButton()
    {
        if (bottle3.bottle >= 1)
        {
            Debug.Log("uisgae");
            bottle3.bottle -= 1;
        }
    }

}
