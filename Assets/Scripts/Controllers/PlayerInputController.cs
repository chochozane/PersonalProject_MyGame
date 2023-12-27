using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);

    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>().normalized;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); // 좌표를 Screen 에서 World(게임상의 좌표) 로 변환 !
        newAim = (worldPos - (Vector2)transform.position).normalized; // 캐릭터가 마우스를 바라보는 방향

        if (newAim.magnitude > 0f)
        {
            CallLookEvent(newAim);

        }
    }
}
