using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private PlayerInputController controller;

    [SerializeField] private Animator anim;

    private void Awake()
    {
        controller = GetComponent<PlayerInputController>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        controller.OnMoveEvent += AnimState;
    }

    private void AnimState(Vector2 direction)
    {
        anim.SetBool("Move", direction.magnitude > 0f);
    }
}
