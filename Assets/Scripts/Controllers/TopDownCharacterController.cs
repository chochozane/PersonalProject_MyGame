using System;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    // event 외부에서는 호출하지 못하게 막는다.
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;
    public event Action OnLookAroundEvent;

    protected bool IsAttacking { get; set; }
    protected bool IsLookingAround { get; set; }

    protected CharacterStatsHandler Stats { get; private set; }

    protected virtual void Awake()
    {
        Stats = GetComponent<CharacterStatsHandler>();
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        if (IsAttacking)
        {
            OnAttackEvent?.Invoke();
        }
    }

    public void CallLookAroundEvent()
    {
        if (IsLookingAround)
        {
            OnLookAroundEvent?.Invoke();
        }
    }

}
