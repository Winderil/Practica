using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyctilLauncher : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject proyectilePrefab;

    public float timeToShoot = 1;
    private float timeSinceLastShoot = 0;

    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot >= timeToShoot)
        {
            Instantiate(proyectilePrefab, ShootPoint.position, ShootPoint.rotation);
            timeSinceLastShoot = 0;
        }
    }
}