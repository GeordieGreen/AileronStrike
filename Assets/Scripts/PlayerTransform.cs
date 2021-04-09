using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public Renderer playerShip;
    public Renderer playerMech;
    public Renderer gun;

    public Transform gunStart;
    public Transform boss;

    public MechFollow mFollow;

    public Animator anim;
   

    public GameObject bossObj;

     
    // Start is called before the first frame update
    void Start()
    {
        playerShip.enabled = true;
        playerMech.enabled = false;
        gameObject.GetComponent<MechFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerShip.enabled == true)
        {
            bossObj.GetComponent<BossMovement>().enabled = false;
            
        }

        else
        {
            bossObj.GetComponent<BossMovement>().enabled = true;
            anim.SetBool("CamTransition", true);
            mFollow.isFollowing = false;
        }
    }

    

    public void StartBoss()
    {

        playerMech.enabled = true;
        playerShip.enabled = false;

        gun.enabled = false;

        gunStart.transform.position = playerMech.transform.position;


        Debug.Log("enabled");

        

    }

    
}
