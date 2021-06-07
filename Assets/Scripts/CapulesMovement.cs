using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapulesMovement : MonoBehaviour
{
    private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 3.91)
        {
            speed = speed + 1;
        }
        if (transform.position.y >= -2)
        {
            speed = speed - 1;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
