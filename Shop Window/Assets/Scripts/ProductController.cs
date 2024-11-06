using UnityEngine;

public class ProductController : MonoBehaviour
{    
    [SerializeField] private ScriptableObject[] _products;
    [SerializeField] private ProductDisplay _productDisplay;
    private int _currentIndex;

    private void Awake()
    {
        ChangeProduct(0);
    }

    public void ChangeProduct(int change)
    {
        _currentIndex += change;
        if (_currentIndex < 0) _currentIndex = _products.Length - 1;
        else if (_currentIndex > _products.Length -1) _currentIndex = 0;

        if(_productDisplay != null) _productDisplay.DisplayProduct((Product) _products[_currentIndex]);
    }

    public void ButtonBuy ()
    {
        if (_productDisplay != null) _productDisplay.BuyProduct((Product)_products[_currentIndex]);                
    }    
}
