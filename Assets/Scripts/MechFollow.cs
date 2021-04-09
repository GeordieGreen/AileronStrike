using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechFollow : MonoBehaviour
{
    public Transform follow;

    public bool isFollowing;
    // Start is called before the first frame update
    void Start()
    {
        isFollowing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = follow.transform.position;
        }
  
    }
}
