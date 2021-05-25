using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge_gravity : MonoBehaviour
{
    bool isFalling = false;
    public float downSpeed = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
            isFalling = true;
        Destroy(gameObject, 30);
    }


    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/30;
            transform.position = new Vector3(transform.position.x,
                transform.position.y - downSpeed,
                transform.position.z);

        }
    }
}
