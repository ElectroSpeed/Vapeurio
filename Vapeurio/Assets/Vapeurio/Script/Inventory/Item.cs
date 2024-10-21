using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    [SerializeField] public string _itemName;
    [SerializeField] public string _category;
    [SerializeField] public string _description;
    [SerializeField] public int _maximumItemPerStack;
}
