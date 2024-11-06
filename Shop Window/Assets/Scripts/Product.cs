using UnityEngine;

[CreateAssetMenu(fileName = "New Product",menuName = "Product/New Product")]
public class Product : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _spriteIcon;
    [SerializeField] private Sprite _spriteResorces0;
    [SerializeField] private Sprite _spriteResorces1;
    [SerializeField] private Sprite _spriteResorces2;
    [field: SerializeField, Range(0, 100)] public int Price {  get; private set; }

    public string Name => this._name;
    public string Description => this._description;
    public Sprite Icon => this._spriteIcon;
    public Sprite Resorces => this._spriteResorces0;
    public Sprite Resorces1 => this._spriteResorces1;
    public Sprite Resorces2 => this._spriteResorces2;
}
