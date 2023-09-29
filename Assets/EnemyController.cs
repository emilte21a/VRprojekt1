using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target;

    public Transform enemyBarrel;

    public GameObject enemyBulletPrefab;

    float elapsed = 0f;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Vector3 pos = transform.position;

            pos.x = Random.Range(-10f, 10f);
            pos.z = Random.Range(-10f, 10f);

            transform.position = pos;
        }
    }

    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }

        elapsed += Time.deltaTime;
        if (elapsed >= 2f)
        {
            elapsed = elapsed % 2f;
            OutputTime();
        }
    }



    void OutputTime()
    {
        Instantiate(enemyBulletPrefab, enemyBarrel.position, enemyBarrel.rotation);
    }
}
