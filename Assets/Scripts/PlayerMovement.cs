using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerrb;
    Animator animator;
    float Speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed*Time.deltaTime);
            animator.SetTrigger("Walk");
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
            animator.SetTrigger("Jump");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //transform.Translate(Vector3.up * Speed * Time.deltaTime);
            animator.SetTrigger("Shoot");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            animator.SetTrigger("Die");
        }
    }
}
