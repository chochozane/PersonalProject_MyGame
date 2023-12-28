using UnityEngine;

public class TopDownAttack : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Animator _animator;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>(); // _controller 를 GetComponent 하는걸 까먹어서 에러났었음 ^.^
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
