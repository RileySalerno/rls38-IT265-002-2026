using UnityEngine;

public enum TileType
{
    Empty,
    Gear,
    Enemy,
    Challenge
}

public class Tile : MonoBehaviour
{
    public TileType type;
}