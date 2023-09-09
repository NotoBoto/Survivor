using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [HideInInspector] public PlayerModel PlayerModel;
    [HideInInspector] public PlayerView PlayerView;

    private Rigidbody2D _playerRigidbody;

    private void Awake()
    {
        PlayerModel = new PlayerModel();
        PlayerModel.Speed = 1.0f;
        PlayerModel.WoodCount = 0;
        PlayerModel.StoneCount = 0;

        PlayerView = GetComponent<PlayerView>();

        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new(moveX, moveY);
        movement.Normalize();

        _playerRigidbody.velocity = movement * PlayerModel.Speed;   
    }
}
