using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Work now");
        anim.Play("Moving_Pillars_anim");
    }


}
