using UnityEngine;

public class DiceRoller : MonoBehaviour
{
    public int RollDice()
    {
        int roll = Random.Range(1, 7);
        Debug.Log("Rolled: " + roll);
        return roll;
    }
}