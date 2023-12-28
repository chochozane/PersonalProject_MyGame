using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Rigidbody2D _rigidbody;
    private CharacterStatsHandler _stats;

    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer _characterWeaponRenderer;

    private Vector2 _movementDirection = Vector2.zero; // 이걸 활용해서 이동 구현 !
    private Vector2 _knockback = Vector2.zero;
    private float knockbackDuration = 0.0f;

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

        if (knockbackDuration > 0.0f)
        {
            knockbackDuration -= Time.fixedDeltaTime; // deltaTime 은 Update 에서 사용, FixedUpdate 에서는 fixedDeltaTime 사용 !
        }
    }

    private void ApplyKnockback(Transform other, float power, float duration)
    {
        knockbackDuration = duration;
        _knockback = -(other.position - transform.position).normalized * power;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= _stats.CurrentStats.speed; // 속도 up

        if (knockbackDuration > 0.0f)
        {
            direction += _knockback;
        }

        _rigidbody.velocity = direction;
    }

    private void LookAround()
    {
        if (_movementDirection.x < 0f)
        {
            characterRenderer.flipX = true;
            _characterWeaponRenderer.flipX = true;

            // todo 무기의 x좌표도 flip 시키고 싶은데..
            Vector3 newPos = new Vector3(-0.5f, -0.04f, 0f);
            _characterWeaponRenderer.transform.position = newPos;

            

        }

        if (_movementDirection.x >= 0f)
        {
            characterRenderer.flipX = false;
            _characterWeaponRenderer.flipX = false;
        }
    }
}
