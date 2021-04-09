using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    public float bulletSpeed = 50f;
    public float bulletLife = 10f;

    public float damage = 10f;

    private float bulletTime;

    private Rigidbody rb;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnEnable()
    {
        bulletTime = bulletLife;
        rb.velocity = transform.up * bulletSpeed;

    }



   
    void Update()
    {
        bulletTime -= Time.deltaTime;
        if (bulletTime <= 0f)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.transform.name);

        EnemyDamage target = other.transform.GetComponent<EnemyDamage>();
        if (target != null)
        {
            target.TakeDamage(damage);
        }

        //GameObject impactGameObj = Instantiate(impactEffect, other.point, Quaternion.LookRotation(other.normal));
        //Destroy(impactGameObj, 1f);

        //Change to pool
    }


}
