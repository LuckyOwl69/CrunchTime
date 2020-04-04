using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    bool canPressButton;

    bool playerTurn;

    bool AttackSelect;
    bool MagicSelect;
    bool ItemSelect;

    public GameObject menuArrow;

    public GameObject optionAttackPosition;
    public GameObject optionMagicPosition;
    public GameObject optionItemPosition;

    void Start()
    {
        playerTurn = false;
        canPressButton = true;
        AttackSelect = true;
    }

    void Update()
    {
        if(!playerTurn)
            menuArrow.SetActive(false);

        if (playerTurn)
        {
            menuArrow.SetActive(true);
        }

        if(AttackSelect == true)
        {
            MagicSelect = false;
            ItemSelect = false;

            //menuArrow.transform.position = new Vector2(optionAttackPosition.transform.position.x, optionAttackPosition.transform.position.y);

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                menuArrow.transform.position = new Vector2(optionMagicPosition.transform.position.x, optionMagicPosition.transform.position.y);

                MagicSelect = true;

            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                menuArrow.transform.position = new Vector2(optionItemPosition.transform.position.x, optionItemPosition.transform.position.y);

                ItemSelect = true;
            }
        }

        if(MagicSelect == true)
        {
            AttackSelect = false;
            ItemSelect = false;

            //menuArrow.transform.position = new Vector2(optionMagicPosition.transform.position.x, optionMagicPosition.transform.position.y);

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                menuArrow.transform.position = new Vector2(optionAttackPosition.transform.position.x, optionAttackPosition.transform.position.y);

                AttackSelect = true;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                menuArrow.transform.position = new Vector2(optionItemPosition.transform.position.x, optionItemPosition.transform.position.y);

                ItemSelect = true;
            }
        }

        if(ItemSelect == true)
        {
            AttackSelect = false;
            MagicSelect = false;

            //menuArrow.transform.position = new Vector2(optionItemPosition.transform.position.x, optionItemPosition.transform.position.y);

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                menuArrow.transform.position = new Vector2(optionMagicPosition.transform.position.x, optionMagicPosition.transform.position.y);

                MagicSelect = true;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                menuArrow.transform.position = new Vector2(optionAttackPosition.transform.position.x, optionAttackPosition.transform.position.y);

                AttackSelect = true;
            }
        }




        if (Input.GetKeyDown(KeyCode.Return))
            playerTurn = !playerTurn;
    }
}
