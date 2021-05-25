using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_scriot : MonoBehaviour
{

    public static bool ShopOpen = false;
    public GameObject ShopOpenUI;
    public GameObject HealthBarUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            if (ShopOpen)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

    }

    public void ExitButton()
    {
        Resume();
    }

    public void Resume()
    {
        ShopOpenUI.SetActive(false);
        HealthBarUI.SetActive(true);
        Time.timeScale = 1f;
        ShopOpen = false;
    }

    public void Pause()
    {
        ShopOpenUI.SetActive(true);
        HealthBarUI.SetActive(false);
        Time.timeScale = 0f;
        ShopOpen = true;
    }
}
