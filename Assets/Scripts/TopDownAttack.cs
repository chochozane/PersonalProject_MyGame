using UnityEngine;

public class TopDownAttack : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Animator _animator;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>(); // _controller �� GetComponent �ϴ°� ��Ծ ���������� ^.^
        _animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        _controller.OnAttackEvent += Attack;

    }

    private void Attack()
    {
        _animator.SetTrigger("Attack");
    }

    private void Hit()
    {
        _animator.SetTrigger("IsHit");
    }
}
