using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _moneyText, _inventoryText;
    public int Money = 100;

   
public void AddItemInInventory(string item)
    {
        _moneyText.text = Money.ToString();
        _inventoryText.text += "\n" + item;
    }
}
