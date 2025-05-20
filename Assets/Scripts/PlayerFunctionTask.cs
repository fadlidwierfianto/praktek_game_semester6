using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFunctionTask : MonoBehaviour
{
    public int PlayerHealth = 0;
    public int PlayerArmor = 0;
    public int PlayerDamage = 0;
    int realdamage = 0;
    bool PlayerAlive = true;

    void GetPlayerStatus()
    {
        Debug.Log("Nyawa player saat ini adalah: " + PlayerHealth);
    }

    void CalculateEffectiveDamage()
    {
        realdamage = PlayerDamage - PlayerArmor;

        if (realdamage > 0)
        {
            Debug.Log("Player terkena damage sebesar " + realdamage);
        }
        else
        {
            realdamage = 0;
            Debug.Log("Player tidak terkena damage");
        }
    }

    void IsPlayerAlive()
    {
        int HealthNow = PlayerHealth - realdamage;

        if (HealthNow > 0)
        {
            PlayerAlive = true;
            Debug.Log("apakah kondisi player saat ini masih hidup? " + PlayerAlive);
        }
        else
        {
            PlayerAlive = false;
            Debug.Log("apakah kondisi player saat ini masih hidup? " + PlayerAlive);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GetPlayerStatus();
        CalculateEffectiveDamage();
        IsPlayerAlive();
    }

    // Update is called once per frame
    void Update() { }
}
