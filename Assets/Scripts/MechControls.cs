using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechControls : MonoBehaviour
{
    private PlayerActions playerActions;

    private float speed = 15f;

    public MechFollow mFollow;

    public Transform boss;

    public static int moveSpeed = 5;



    private void Awake()
    {
        playerActions = new PlayerActions();
    }

    // Start is called before the first frame update
    void Start()
    {
        boss = GetComponent<Transform>();
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
        if (mFollow.isFollowing == false)
        {
            Movement();
            this.transform.LookAt(boss);
            
        }
        if (playerActions.Mech.Move.triggered)
        {
            transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
        }
        
    }

    void Movement()
    {
        float h = playerActions.Mech.Horizontal.ReadValue<float>();
        float v = playerActions.Mech.Vertical.ReadValue<float>();

        Vector3 currentPos = transform.position;
        currentPos.x += h * speed * Time.deltaTime;
        currentPos.y += v * speed * Time.deltaTime;

        transform.position = currentPos;

        float rh = playerActions.Mech.RotationHorizontal.ReadValue<float>();
        float rv = playerActions.Mech.RotationVertical.ReadValue<float>();

        Quaternion currentRot = transform.rotation;
        currentRot.y += rh * 2 * Time.deltaTime;
        currentRot.x += rv * 2 * Time.deltaTime;

        transform.rotation = currentRot;


    }
}
