using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private int _numberInventorySlot;
    [SerializeField] private int _numberInventorySlotPerLine;
    [SerializeField] private int _inventorySlotDistance;

    [SerializeField] private GameObject _slot;
    private int _column = 0;
    private int _line = 0;
    private GameObject _generateSlot;

    private void Start()
    {
        SetInventory();
    }

    private void SetInventory()
    {
        for (int slot = 1; slot < _numberInventorySlot + 1; slot++)
        {
            _generateSlot = Instantiate(_slot, new Vector3((_line * _inventorySlotDistance), -((_column * _inventorySlotDistance)), 0), Quaternion.identity);
            _generateSlot.transform.parent = transform;
            _line++;
            if (slot % _numberInventorySlotPerLine == 0)
            {
                _column++;
                _line = 0;
            }
            Debug.Log(slot);
        }
    }

    public void AddItem()
    {

    }

    public void RemoveItem()
    {

    }

    public void DragItem()
    {

    }
}
