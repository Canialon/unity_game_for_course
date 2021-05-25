using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle_scrept : MonoBehaviour
{
    public float rotationSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<tru_move_the_hero>().bottle++;
            Destroy(gameObject);
        }
    }
}
