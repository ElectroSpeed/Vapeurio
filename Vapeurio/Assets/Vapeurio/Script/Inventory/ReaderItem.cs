using UnityEngine;

public class ReaderItem : MonoBehaviour
{
    public static Item _item;

    public string _itemName;
    public string _category;
    public string _description;
    public int _maximumItemPerStack;

    private void Awake()
    {
        _item = GetComponent<Item>();

        _itemName = _item._itemName;
        _category = _item._category;
        _description = _item._description;
        _maximumItemPerStack = _item._maximumItemPerStack;
    }
}
