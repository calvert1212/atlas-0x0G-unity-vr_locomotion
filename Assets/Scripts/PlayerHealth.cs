using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 75)
        {
            Debug.Log("One tick gone");
        }
        else if (health <= 50)
        {
            Debug.Log("Two tick gone");
        }
        else if (health <= 25)
        {
            Debug.Log("Three tick gone");
        }
        else if (health <= 0)
        {
            Debug.Log("You died.");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyLaser"))
        {
            health = health - 25f;
        }
    }
}
