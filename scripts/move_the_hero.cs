using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_the_hero : MonoBehaviour
{

    public float speed = 2f;
    Rigidbody rb;

    //лимит камеры
    [SerializeField]
    float leftLimit;
    [SerializeField]
    float RightLimit;
    [SerializeField]
    float BottomLimit;
    [SerializeField]
    float UpperLimit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {


        float xMov = -Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector3(xMov, rb.velocity.y) * speed;



        transform.position = new Vector3
            (
            Mathf.Clamp(transform.position.x, leftLimit, RightLimit),
            Mathf.Clamp(transform.position.y, BottomLimit, UpperLimit),
            transform.position.z
            );
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(new Vector2(leftLimit, UpperLimit), new Vector2(RightLimit, UpperLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, BottomLimit), new Vector2(RightLimit, BottomLimit));
        Gizmos.DrawLine(new Vector2(leftLimit, UpperLimit), new Vector2(leftLimit, BottomLimit));
        Gizmos.DrawLine(new Vector2(RightLimit, UpperLimit), new Vector2(RightLimit, BottomLimit));
    }
}
