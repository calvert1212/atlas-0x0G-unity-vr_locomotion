using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 100f;

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Headshot"))
        {
            health = health - 100;
        }
        else if (other.CompareTag("Bodyshot"))
        {
            health = health - 25;
        }
    }
}
