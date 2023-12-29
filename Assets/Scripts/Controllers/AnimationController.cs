using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private PlayerInputController controller; // ���⼭ TopDownCharacterController �� controller �����Դٰ� �������� ;; �� ��������

    private Animator anim;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
        anim = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    private void AnimState(Vector2 direction)
    {
        anim.SetBool("Move", direction.magnitude > 0f);
    }

    private void Hit() //todo Hit()
    {
        anim.SetTrigger("IsHit");
    }
}
