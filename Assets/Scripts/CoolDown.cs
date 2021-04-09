using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    public float maxStamina = 100;
    public float currentStamina;

    public Image staminaBar;

    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static CoolDown instance;

    public PlayerController playControl;

    private PlayerActions playerActions;

    public bool usingStamina;

    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        playerActions = new PlayerActions();

        playerActions.Ship.Boost.started += ctx => UseStamina(0.40f);
        playerActions.Ship.Break.started += ctx => UseStamina(0.40f);
        playerActions.Ship.Boost.canceled += ctx => RegenStamina();
        playerActions.Ship.Break.canceled += ctx => RegenStamina();
    }

    void Start()
    {
        staminaBar = GetComponent<Image>();
        currentStamina = maxStamina;
        staminaBar.fillAmount = maxStamina;

        usingStamina = false;
    }

    // Update is called once per frame
    void Update()
    {
        staminaBar.fillAmount = currentStamina / maxStamina;
        if (usingStamina)
        {
            UseStamina(0.40f);
        }
    }

    public void UseStamina(float amount)
    {
        if (currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.fillAmount = currentStamina;

            if (regen != null)
            {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenStamina());
        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(0.1f);

        while (currentStamina < maxStamina)
        {
            currentStamina += maxStamina / 100;

            staminaBar.fillAmount = currentStamina;

            yield return regenTick;
        }
    }


}
