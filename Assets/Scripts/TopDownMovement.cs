using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Rigidbody2D _rigidbody;

    private Vector2 _movementDirection = Vector2.zero; // 이걸 활용해서 이동 구현 !

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction) // 값이 0 인 _movementDirection 를 바꿔주기 위해 
    {
        _movementDirection = direction;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= 5; // 속도 up
        _rigidbody.velocity = direction;
    }
}
