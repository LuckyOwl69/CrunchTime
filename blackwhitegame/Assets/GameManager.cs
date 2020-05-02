using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static Vector3 overworldPos;

    public float overworldPosX;
    public float overworldPosY;

    //public BattleSystem BattleSystemObject;

    public float PlayerHealth;

    bool madeCoffee = false;

    void Update()
    {

    }

    void Awake()
    {
        if (instance == null)
        {
            overworldPos.x = overworldPosX;
            overworldPos.y = overworldPosY;
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void madeCoffeeFunction()
    {
        madeCoffee = true;
    }
}
