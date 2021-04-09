using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  
    private ProjectilePool objectPool;

    private AltPool altPool;

    private PlayerActions playerActions;

    private void Awake()
    {
        objectPool = GetComponent<ProjectilePool>();
        playerActions = new PlayerActions();

        altPool = GetComponent<AltPool>();

        //playerActions.Ship.AltShoot.started += ctx => RapidFire();
    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        if (playerActions.Ship.Shoot.triggered)
        {
            Shoot();
            Debug.Log("A Button");

        }
        if (playerActions.Ship.AltShoot.triggered)
        {
            LongShot();
            Debug.Log("B Button");
        }
        
    }

    void Shoot()
    {
        objectPool.GetObjFromPool();
    }

    void LongShot()
    {
        altPool.GetObjFromPool();

        Debug.Log(altPool);
    }
}
