using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;

    public List<CardData> allCards = new List<CardData>();

    private void Awake()
    {
        Instance = this;
    }

    public List<CardData> DrawCards(int amount)
    {
        List<CardData> drawn = new List<CardData>();

        for (int i = 0; i < amount; i++)
        {
            int index = Random.Range(0, allCards.Count);
            drawn.Add(allCards[index]);
        }

        return drawn;
    }
}