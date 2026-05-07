using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Info")]
    public string playerName;

    [Header("Board")]
    public int currentTileIndex = 0;

    [Header("Stats")]
    public int maxHealth = 20;
    public int maxMana = 10;

    [HideInInspector] public int health;
    [HideInInspector] public int mana;

    [Header("Inventory")]
    public List<CardData> inventory = new List<CardData>();

    [Header("Starter Cards")]
    public List<CardData> starterCards = new List<CardData>();


    [Header("Combat Loadout")]
    public CardData spell1;
    public CardData spell2;
    public CardData armor;


    private void Start()
    {
        ResetStats();
        GiveStarterCards();
    }


    public void ResetStats()
    {
        health = maxHealth;
        mana = maxMana;
    }

    public void GiveStarterCards()
    {
        inventory.Clear();

        foreach (CardData card in starterCards)
        {
            inventory.Add(card);
        }
    }

    public void AddCard(CardData card)
    {
        inventory.Add(card);

        Debug.Log(playerName +
            " gained card: " + card.cardName);
    }

    public void RemoveRandomCard()
    {
        if (inventory.Count == 0)
            return;

        int randomIndex =
            Random.Range(0, inventory.Count);

        Debug.Log(playerName +
            " lost card: " +
            inventory[randomIndex].cardName);

        inventory.RemoveAt(randomIndex);
    }

    public void TakeDamage(int amount)
    {
        // ARMOR REDUCTION
        if (armor != null)
        {
            amount -= armor.damageReduction;
        }

        amount = Mathf.Max(0, amount);

        health -= amount;

        Debug.Log(playerName +
            " took " + amount + " damage");
    }


    public void Heal(int amount)
    {
        health += amount;

        if (health > maxHealth)
            health = maxHealth;

        Debug.Log(playerName +
            " healed " + amount);
    }

    public void RestoreMana(int amount)
    {
        mana += amount;

        if (mana > maxMana)
            mana = maxMana;

        Debug.Log(playerName +
            " restored " + amount + " mana");
    }

    public bool SpendMana(int amount)
    {
        if (mana < amount)
        {
            Debug.Log(playerName +
                " does not have enough mana!");

            return false;
        }

        mana -= amount;
        return true;
    }
    // does the player have that card
    public bool HasCard(CardData card)
    {
        return inventory.Contains(card);
    }

    //Loadout set up
    public void SetLoadout(
        CardData newSpell1,
        CardData newSpell2,
        CardData newArmor)
    {
        spell1 = newSpell1;
        spell2 = newSpell2;
        armor = newArmor;
    }
}