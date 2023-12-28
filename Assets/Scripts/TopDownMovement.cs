using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Rigidbody2D _rigidbody;
    private CharacterStatsHandler _stats;

    [SerializeField] private SpriteRenderer characterRenderer;

    private Vector2 _movementDirection = Vector2.zero; // �̰� Ȱ���ؼ� �̵� ���� !

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

    private void Move(Vector2 direction) // ���� 0 �� _movementDirection �� �ٲ��ֱ� ���� 
    {
        _movementDirection = direction;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= _stats.CurrentStats.speed; // �ӵ� up
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
