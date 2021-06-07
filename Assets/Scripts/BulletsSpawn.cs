using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsSpawn : MonoBehaviour
{

    public GameObject bullet;
    public float bulletspeed;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Shoot");
            BulletDirection();
        }
    }
    private void BulletDirection()
    {

        GameObject bulletref = Instantiate(bullet);
        bulletref.transform.position = transform.position+new Vector3(0,3.3f,0);
        Rigidbody rb = bulletref.GetComponent<Rigidbody>();
        //rb.AddForce(direction * bulletspeed);
        Camera camera = GetComponent<Camera>();
        rb.velocity = camera.transform.rotation * Vector3.forward * bulletspeed;
    }
}
