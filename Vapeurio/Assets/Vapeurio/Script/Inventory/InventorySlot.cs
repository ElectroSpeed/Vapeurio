using UnityEngine;

[System.Serializable]
public class InventorySlot : MonoBehaviour
{
    public ReaderItem _item;
    public int _amount;

    public void SetInventorySlot (ReaderItem item)
    {
        _item = item;
        _amount = item._maximumItemPerStack;
    }
}
