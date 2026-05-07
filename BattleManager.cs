using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public PlayerController player1;
    public PlayerController player2;

    public void StartBattle(PlayerController p1, PlayerController p2)
    {
        player1 = p1;
        player2 = p2;

        StartCoroutine(BattleLoop());
    }

    System.Collections.IEnumerator BattleLoop()
    {
        while (player1.health > 0 && player2.health > 0)
        {
            yield return PlayerTurn(player1, player2);
            if (player2.health <= 0) break;

            yield return PlayerTurn(player2, player1);
        }

        Debug.Log("Battle Ended");
    }

    System.Collections.IEnumerator PlayerTurn(PlayerController attacker, PlayerController defender)
    {
        int damage = Random.Range(2, 6);
        defender.health -= damage;

        Debug.Log(attacker.playerName + " deals " + damage);

        yield return new WaitForSeconds(1f);
    }
}