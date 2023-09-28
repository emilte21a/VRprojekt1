using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
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
}
