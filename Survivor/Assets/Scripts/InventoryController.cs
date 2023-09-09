using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [HideInInspector] public InventoryModel InventoryModel;
    [HideInInspector] public InventoryView InventoryView;

    [HideInInspector] public SlotController[] SlotControllers;
    
    private PlayerController _playerController;

    private void Awake()
    {
        InventoryModel = new InventoryModel();
        InventoryView = GetComponent<InventoryView>();

        SlotControllers = GetComponentsInChildren<SlotController>();

        _playerController = Camera.main.transform.GetComponentInParent<PlayerController>();
    }
}
