using UnityEngine;

public enum CardType
{
    Spell,
    Armor
}

[CreateAssetMenu(menuName = "Gearoseum/Card")]
public class CardData : ScriptableObject
{
    public string cardName;
    public CardType type;

    [TextArea] public string description;

    // Spell
    public int power;
    public int manaCost;

    // Armor
    public int damageReduction;

    public Sprite artwork;
}