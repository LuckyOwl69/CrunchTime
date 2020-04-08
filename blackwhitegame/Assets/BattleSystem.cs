using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public static int enemiesOnCurrentFloor;
    //public int enemyPrefabsSize = Random.Range(0, 50);


    public GameObject playerPrefab;
    //public GameObject enemyPrefab;

    

    public GameObject attackButton;
    public GameObject magicButton;
    public GameObject cancelButton;

    public GameObject magic1Button;



    public List<GameObject> enemyPrefabs;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;    

    Unit playerUnit;
    Unit enemyUnit;


    public Text playerHealthText;
    public Text dialogueText;
    public Text playerNameText;

    public BattleHUD playerHUD;

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
        playerNameText.text = playerUnit.unitName;

        //show player health in text form
        playerHealthText.text = playerUnit.currentHP.ToString() + " / " + playerUnit.maxHP.ToString() + " HP";

        attackButton.transform.gameObject.SetActive(true);
        magicButton.transform.gameObject.SetActive(true);

        //magic spells
        magic1Button.transform.gameObject.SetActive(false);

    }

    IEnumerator SetupBattle()
    {
        GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
        playerUnit = playerGO.GetComponent<Unit>();

        GameObject enemyGo = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)], enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Unit>();

        //flavour text as soon as battle begins
        dialogueText.text = enemyUnit.unitName + " " + enemyUnit.unitJob + "!";
        playerHUD.SetHUD(playerUnit);

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();

    }

    IEnumerator PlayerAttack() 
    {
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        dialogueText.text = "The attack is successful!";

        yield return new WaitForSeconds(2f);

        if(isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

    public void PlayerMagic()
    {
        attackButton.transform.gameObject.SetActive(false);
        magicButton.transform.gameObject.SetActive(false);

        //magic spells
        magic1Button.transform.gameObject.SetActive(true);

    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + " attacks! You take " + enemyUnit.damage + " damage!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if(isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "You won the battle!";
            SceneManager.LoadScene("Top down");

        }
        else if(state == BattleState.LOST)
        {
            dialogueText.text = "You were defeated.";
        }
    }

    void PlayerTurn()
    {
        dialogueText.text = "Your turn: ";
        //dialogueText.text = enemyUnit.unitName + " Health = " + enemyUnit.currentHP;

    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
            return;

        StartCoroutine(PlayerAttack());
    }
}
