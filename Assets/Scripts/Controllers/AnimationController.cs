using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private PlayerInputController controller; // 여기서 TopDownCharacterController 로 controller 가져왔다가 에러떴네 ;; 휴 조심하자

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
