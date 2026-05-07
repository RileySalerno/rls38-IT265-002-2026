using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CombatUI : MonoBehaviour
{
    public GameObject loadoutPanel;
    public GameObject combatPanel;

    public Button spell1Button;
    public Button spell2Button;

    public TextMeshProUGUI playerHPText;
    public TextMeshProUGUI enemyHPText;
    public TextMeshProUGUI resultText;

    private void Start()
    {
        loadoutPanel.SetActive(false);
        combatPanel.SetActive(false);
        resultText.gameObject.SetActive(false);
    }

    public void ShowLoadout()
    {
        loadoutPanel.SetActive(true);
        combatPanel.SetActive(false);
    }

    public void ShowCombat(PlayerController player, PlayerController enemy)
    {
        loadoutPanel.SetActive(false);
        combatPanel.SetActive(true);

        spell1Button.onClick.RemoveAllListeners();
        spell2Button.onClick.RemoveAllListeners();

        spell1Button.GetComponentInChildren<TextMeshProUGUI>().text =
            player.spell1.cardName;

        spell2Button.GetComponentInChildren<TextMeshProUGUI>().text =
            player.spell2.cardName;

        spell1Button.onClick.AddListener(() => CombatManager.Instance.UseSpell(0));
        spell2Button.onClick.AddListener(() => CombatManager.Instance.UseSpell(1));
    }

    public void UpdateUI(PlayerController player, PlayerController enemy)
    {
        playerHPText.text = "Player HP: " + player.health;
        enemyHPText.text = "Enemy HP: " + enemy.health;
    }

    public void ShowResult(string result)
    {
        resultText.gameObject.SetActive(true);
        resultText.text = result;
    }
}