using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateHand(PlayerController player)
    {
        Debug.Log("Showing hand for: " + player.playerName);

        foreach (var card in player.inventory)
        {
            Debug.Log(card.cardName);
        }
    }
}