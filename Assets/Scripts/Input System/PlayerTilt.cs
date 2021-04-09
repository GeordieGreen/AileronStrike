using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTilt : MonoBehaviour
{
    private PlayerActions playerActions;
    // Start is called before the first frame update

    private void Awake()
    {
        playerActions = new PlayerActions();

        playerActions.Ship.TiltLeft.started += ctx => TiltLeft();
        playerActions.Ship.TiltRight.started += ctx => TiltRight();
        playerActions.Ship.TiltLeft.canceled += ctx => TiltCancel();
        playerActions.Ship.TiltRight.canceled += ctx => TiltCancel();

    }
    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
 
    }

    void TiltLeft()
    {
        //transform.localRotation = Quaternion.Euler(0, 0, 90);

        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0,0,90f), 180f * Time.deltaTime); 

    }

    void TiltRight()
    {
        //transform.localRotation = Quaternion.Euler(0, 0, -90);
        //transform.eulerAngles += new Vector3(0, 0, -45);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, -90f), 180f * Time.deltaTime);
    }

    void TiltCancel()
    {
        //transform.localRotation = Quaternion.Euler(0, 0, 0);
        //transform.eulerAngles += new Vector3(0, 0, 0);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, 0), 180f * Time.deltaTime);
    }
}
