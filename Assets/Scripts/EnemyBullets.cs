using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bulletref = Instantiate(EnemyBullet);
        bulletref.transform.position = new Vector3(64.98f, 7.62f, 40.86f);
        Rigidbody rb = bulletref.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 1.0f);
    }
}
