using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public List<Tile> tiles;
    public TileEffects tileEffects;

    public IEnumerator MovePlayer(PlayerController player, int steps)
    {
        Tile landedTile = null;

        for (int i = 0; i < steps; i++)
        {
            player.currentTileIndex++;

            if (player.currentTileIndex >= tiles.Count)
                player.currentTileIndex = 0;

            landedTile = tiles[player.currentTileIndex];

            player.transform.position =
                landedTile.transform.position + Vector3.up * 1f;

            yield return new WaitForSeconds(0.2f);
        }

        Debug.Log("Landed on " + landedTile.type);
        ResolveTile(landedTile, player);
    }

    void ResolveTile(Tile tile, PlayerController player)
    {
        switch (tile.type)
        {
            case TileType.Gear:
                tileEffects.ResolveGearTile(player);
                break;

            case TileType.Enemy:
                CombatManager.Instance.StartCombat(player, GameManager.Instance.GetEnemy());
                break;

            case TileType.Challenge:
                Debug.Log("Challenge Tile Triggered");
                break;
        }
    }
}