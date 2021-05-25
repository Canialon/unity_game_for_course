using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScrept : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject ShopUi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (GameIsPaused)
            {
                ShopUi.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                ShopUi.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }


        }
    }
}
