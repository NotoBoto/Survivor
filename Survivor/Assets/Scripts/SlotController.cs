using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotController : MonoBehaviour
{
    [HideInInspector] public SlotModel SlotModel;
    [HideInInspector] public SlotView SlotView;

    private PlayerController _playerController;

    private void Awake()
    {
        SlotModel = new SlotModel();
        SlotView = GetComponent<SlotView>();

        _playerController = Camera.main.transform.GetComponentInParent<PlayerController>();
    }
}
