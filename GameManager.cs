using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<PlayerController> players;
    private int currentPlayerIndex;

    public BoardManager board;
    public DiceRoller dice;

    public GameState currentState;

    public enum GameState
    {
        BoardPhase,
        BattlePhase,
        Tournament
    }

    private void Awake()
    {
        Instance = this;
    }

    public PlayerController GetCurrentPlayer()
    {
        return players[currentPlayerIndex];
    }

    public PlayerController GetEnemy()
    {
        return players[(currentPlayerIndex + 1) % players.Count];
    }

    public void RollAndMove()
    {
        StartCoroutine(RollMoveAndResolve());
    }

    private IEnumerator RollMoveAndResolve()
    {
        PlayerController player = GetCurrentPlayer();

        int roll = dice.RollDice();

        yield return StartCoroutine(board.MovePlayer(player, roll));

        EndTurn();
    }


    public void StartTurn()
    {
        Debug.Log("Turn: " + GetCurrentPlayer().playerName);

        UIManager.Instance.UpdateHand(GetCurrentPlayer());
    }

    public void EndTurn()
    {
        currentPlayerIndex++;

        if (currentPlayerIndex >= players.Count)
            currentPlayerIndex = 0;


        Debug.Log("Next Player: " + GetCurrentPlayer().playerName);

        StartTurn();
    }
}