using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFunction : MonoBehaviour
{
    public float laserSpeed = 0.25f;
    private Rigidbody rb;
    private Camera camera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camera = FindAnyObjectByType<Camera>();

        transform.LookAt(camera.transform);

        Vector3 dirToCam = (camera.transform.position - transform.position).normalized;
        transform.up = dirToCam;

        rb.velocity = transform.up * laserSpeed;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player was hit");
        }
        else
        {
            Debug.Log("Hit an object, not a player");
        }
        Destroy(gameObject);
    }
}
