using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Rigidbody2D _rigidbody;
    private CharacterStatsHandler _stats;

    [SerializeField] private SpriteRenderer characterRenderer;

    private Vector2 _movementDirection = Vector2.zero; // 이걸 활용해서 이동 구현 !

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _stats = GetComponent<CharacterStatsHandler>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnLookAroundEvent += LookAround;
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
        direction *= _stats.CurrentStats.speed; // 속도 up
        _rigidbody.velocity = direction;
    }

    private void LookAround()
    {
        if (_movementDirection.x < 0f)
        {
            characterRenderer.flipX = true;
        }

        if (_movementDirection.x >= 0f)
        {
            characterRenderer.flipX = false;
        }
    }
}
