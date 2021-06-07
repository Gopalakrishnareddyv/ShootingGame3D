using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScore : MonoBehaviour
{
    public int score=0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            score = score + 1;
        }
    }
}
