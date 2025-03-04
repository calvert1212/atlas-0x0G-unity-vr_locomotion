using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeadMovements : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;

    private Coroutine lookCoroutine;

    public void startRotating()
    {
        if (lookCoroutine == null)
        {
            StopCoroutine(lookCoroutine);
        }
        lookCoroutine = StartCoroutine(LookAt());
    }

    private IEnumerator LookAt()
    {
        Quaternion lookRotation = Quaternion.LookRotation(target.position - transform.position);

        float time = 0;

        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);

            time += Time.deltaTime * speed;

            yield return null;
        }
    }

    void Update()
    {
        transform.LookAt(target);
        transform.rotation *= Quaternion.FromToRotation(Vector3.left, Vector3.right);
    }
}
