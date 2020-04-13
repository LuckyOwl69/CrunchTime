using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Vector3 overworldPos;

    //public BattleSystem BattleSystemObject;

    public float PlayerHealth;

    Unit playerUnit;


    void Update()
    {
        PlayerHealth = playerUnit.currentHP;
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
