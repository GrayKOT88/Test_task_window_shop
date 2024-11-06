using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductDisplay : MonoBehaviour
{       
    [SerializeField] TextMeshProUGUI _nameText, _descriptionText, _price;
    [SerializeField] Image _imageProduct, _imageRecorces, _imageRecorces1, _imageRecorces2;

    [SerializeField] private Inventory _inventory;

    public void DisplayProduct(Product product)
    {        
        _nameText.text = product.Name;
        _descriptionText.text = product.Description;
        _imageProduct.sprite = product.Icon;
        _imageRecorces.sprite = product.Resorces;
        _imageRecorces1.sprite = product.Resorces1;
        _imageRecorces2.sprite = product.Resorces2;
        _price.text = product.Price.ToString();        
    }

    public void BuyProduct(Product product)
    {
        if (_inventory.Money >= product.Price)
        {            
            _inventory.Money -= product.Price;
            _inventory.AddItemInInventory(product.Name);           
        }
    }
}
