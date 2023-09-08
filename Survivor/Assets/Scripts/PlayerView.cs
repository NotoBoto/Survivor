using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private Canvas _canvas;
    private TextMeshProUGUI _materialsList;

    private void Awake()
    {
        _canvas = FindAnyObjectByType<Canvas>();
        _materialsList = _canvas.transform.Find("MaterialsList").GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMaterialsList(int woodCount, int stoneCount)
    {
        _materialsList.text = woodCount + " Wood \n" + stoneCount + " Stone";
    }
}
