using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardTrajectory : MonoBehaviour
{
    public static int moveSpeed = 20;
    public Vector3 playerDirection = Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(playerDirection * moveSpeed * Time.deltaTime);
    }

}
