using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject laser;
    public bool reload = false;
    public float laserOffset = 0.3f;
    private EnemyMovement enemyTargeting;

    // Start is called before the first frame update
    void Start()
    {
        enemyTargeting = GetComponentInParent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyTargeting.inRange == true && reload == false)
        {
            Debug.Log("Fired");
            Vector3 newLaserPos = transform.position + -(transform.forward) * laserOffset;
            newLaserPos.y = 1.32f;
            Debug.Log(newLaserPos);
            Instantiate(laser, newLaserPos, laser.transform.rotation);

            StartCoroutine(Reloading(2));
        }
    }

    IEnumerator Reloading(int waitTime)
    {
        reload = true;
        yield return new WaitForSeconds(waitTime);
        reload = false;
    }
}
