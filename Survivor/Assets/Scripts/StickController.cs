using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    private PlayerController _player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
            _player = collision.GetComponent<PlayerController>();
            _player.PlayerModel.WoodCount++;
            _player.PlayerView.UpdateMaterialsList(_player.PlayerModel.WoodCount, _player.PlayerModel.StoneCount);
            gameObject.SetActive(false);
            Invoke("Respawn", 60f);
        }
    }

    private void Respawn()
    {
        gameObject.SetActive(true);
    }
}
