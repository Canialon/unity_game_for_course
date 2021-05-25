using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {

            Debug.Log("-1");
            other.gameObject.GetComponent<health_script>().TakeDamage(1);

        }
    }


}
