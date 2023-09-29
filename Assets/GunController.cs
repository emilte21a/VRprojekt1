using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform barrelPoint;
    public GameObject bulletPrefab;
    public void PullTrigger()
    {
         Instantiate(bulletPrefab, barrelPoint.position, barrelPoint.rotation);
    }

}
