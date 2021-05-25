using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_script : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    public heart_system healthBar;
 


private void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }


    void Update()
    {
       if (transform.position.y <= -200)
        {
            FindObjectOfType<level_manager>().Restart();
        }

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            FindObjectOfType<level_manager>().Restart();
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

}
