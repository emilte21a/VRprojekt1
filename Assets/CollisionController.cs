using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "enemyBullet")
        {
            Debug.Log("dudog");
        }
    }

}
