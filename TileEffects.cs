using System.Collections.Generic;
using UnityEngine;

public class TileEffects : MonoBehaviour
{
    public List<CardData> cardPool;

    public void ResolveGearTile(PlayerController player)
    {

        Debug.Log("Gear tile triggered");
        if (cardPool.Count == 0) return;

        CardData c1 = cardPool[Random.Range(0, cardPool.Count)];
        CardData c2 = cardPool[Random.Range(0, cardPool.Count)];

        player.inventory.Add(c1);
        player.inventory.Add(c2);
    }

    public void ResolvePenalty(PlayerController player)
    {
        player.RemoveRandomCard();
    }
}