using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomBattleController : MonoBehaviour
{
    public int battleTrigger = 1000;
    public int battleNumber = 0;

    //public Transform position;

    Vector2 playerPositionStart;
    Vector2 playerPositionCurrent;
    Vector2 playerPositionEnd;

    // Start is called before the first frame update
    void Start()
    {
        //playerPosition1.x = position.x;
        //playerPosition1.y = position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x == transform.position.x + 0.1f)
        //    battleNumber += 1;

        //if (transform.position.hasChanged)
        //    battleNumber +=1;

        //playerPosition2.x = position.x;
        //playerPosition2.y = position.y;

        //if (playerPosition2 = playerPosition1+10)
        //    SceneManager.LoadScene("NormalOffice1");


        if (battleNumber >= 10)
            SceneManager.LoadScene("NormalOffice1");
        //Debug.Log(battleNumber);

        

    }


}
