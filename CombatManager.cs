using UnityEngine;

public enum CombatState
{
    Loadout,
    PlayerTurn,
    EnemyTurn,
    Ended
}

public class CombatManager : MonoBehaviour
{
    public static CombatManager Instance;

    public PlayerController player;
    public PlayerController enemy;

    public CombatState state;

    public CombatUI ui;

    private void Awake()
    {
        Instance = this;
    }

    public void StartCombat(PlayerController p, PlayerController e)
    {
        player = p;
        enemy = e;

        player.ResetStats();
        enemy.ResetStats();

        ui.resultText.gameObject.SetActive(false);

        state = CombatState.Loadout;

        ui.ShowLoadout();

    }

    public void BeginBattle()
    {
        state = CombatState.PlayerTurn;

        ui.ShowCombat(player, enemy);
        ui.UpdateUI(player, enemy);
    }

    public void UseSpell(int index)
    {
        if (state != CombatState.PlayerTurn) return;

        CardData spell = (index == 0) ? player.spell1 : player.spell2;

        if (spell == null) return;
        if (player.mana < spell.manaCost) return;

        player.mana -= spell.manaCost;
        enemy.health -= spell.power;

        ui.UpdateUI(player, enemy);

        if (CheckWin()) return;

        state = CombatState.EnemyTurn;
        Invoke(nameof(EnemyTurn), 1f);
    }

    void EnemyTurn()
    {
        if (state != CombatState.EnemyTurn) return;

        int damage = Random.Range(2, 6);

        if (player.armor != null)
            damage -= player.armor.damageReduction;

        damage = Mathf.Max(0, damage);

        player.health -= damage;

        ui.UpdateUI(player, enemy);

        if (CheckWin()) return;

        state = CombatState.PlayerTurn;
    }

    bool CheckWin()
    {
        if (player.health <= 0)
        {
            ui.ShowResult("You Lose");

            state = CombatState.Ended;

            Invoke(nameof(EndCombat), 2f);

            return true;
        }

        if (enemy.health <= 0)
        {
            ui.ShowResult("You Win");

            state = CombatState.Ended;

            Invoke(nameof(EndCombat), 2f);

            return true;
        }

        return false;
    }

    public void EndCombat()
    {
        ui.combatPanel.SetActive(false);
        ui.loadoutPanel.SetActive(false);

        GameManager.Instance.currentState = GameManager.GameState.BoardPhase;

        Debug.Log("Returned to Board Phase");
    }
}