using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // normalized �ϴ� ������ �밢������ ������ �� �������� �� ���� ���� !
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(newAim); // ��ǥ�� Screen ���� World(���ӻ��� ��ǥ) �� ��ȯ !
        newAim = (worldPos - (Vector2)transform.position).normalized; // ĳ���Ͱ� ���콺�� �ٶ󺸴� ����

        if (newAim.magnitude > 0f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnAttack(InputValue value)
    {
        Debug.Log("OnAttack" + value.ToString());
    }
}
