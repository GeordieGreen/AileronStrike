using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class PlayerController : MonoBehaviour
{
    private PlayerActions playerActions;

    private float speed = 10f;

    public Renderer playerMech;

    public Transform boss;

    public GameObject player;

    public CoolDown coolDown;

    


    private void Awake()
    {
        playerActions = new PlayerActions();

        playerActions.Ship.Boost.started += ctx => BoostSpeed();
        playerActions.Ship.Break.started += ctx => BreakSpeed();
        playerActions.Ship.Boost.canceled += ctx => NormalSpeed();
        playerActions.Ship.Break.canceled += ctx => NormalSpeed();

    }

    private void OnEnable()
    {
        playerActions.Enable();
    }

    private void OnDisable()
    {
        playerActions.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }



    void Movement()
    {
        float h = playerActions.Ship.Horizontal.ReadValue<float>();
        float v = playerActions.Ship.Vertical.ReadValue<float>();

            Vector3 currentPos = transform.position;
            currentPos.x += h * speed * Time.deltaTime;
            currentPos.y += v * speed * Time.deltaTime;

            transform.position = currentPos;
            
    }

  
    void BoostSpeed()
    {
        ForwardTrajectory.moveSpeed = 30;
        speed = 5f;
        coolDown.usingStamina = true;
        
    }

    void BreakSpeed()
    {
        ForwardTrajectory.moveSpeed = 5;
        speed = 5f;
        coolDown.usingStamina = true;
    }

    void NormalSpeed()
    {
        ForwardTrajectory.moveSpeed = 20;
        speed = 10f;
        coolDown.usingStamina = false;
    }

    

    
  
}
