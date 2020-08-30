using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatusInformationManager : MonoBehaviour
{
    public static StatusInformationManager Instance { get; private set; }

    public TextMeshProUGUI playerInformation;
    public Slider playerHpBar;
    public TextMeshProUGUI playerHpPercent;

    public TextMeshProUGUI targetInformation;
    public Slider targetHpBar;
    public TextMeshProUGUI targetHpPercent;

    private void Start()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;

        HideTargetInformation();
    }

    private void HideTargetInformation()
    {
        targetInformation.text = "";
        targetHpBar.value = 1;
        targetHpPercent.text = "";
        targetInformation.gameObject.SetActive(false);
        targetHpBar.gameObject.SetActive(false);
    }

    public void UpdateTargetInformation(WorldObject obj)
    {
        // Hide when object is null.
        if (obj == null)
        {
            HideTargetInformation();
            return;
        }
        // Show if hidden.
        if (!targetInformation.IsActive())
        {
            targetInformation.gameObject.SetActive(true);
            targetHpBar.gameObject.SetActive(true);
        }
        // Update information.
        CharacterDataHolder data = obj.characterData;
        if (data != null)
        {
            targetInformation.text = data.GetName();
        }
    }

    public void UpdatePlayerInformation()
    {
        CharacterDataHolder data = MainManager.Instance.selectedCharacterData;
        playerInformation.text = data.GetName();
    }
}
