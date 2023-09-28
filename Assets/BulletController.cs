using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField]
    float bulletForce = 5;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward*bulletForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "terrain")
        {
            Destroy(this.gameObject);
        }
    }

}
