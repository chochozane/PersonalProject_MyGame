using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "TopDownCharacterController/Attacks/Default", order = 0)]
public class AttackSO : ScriptableObject
{
    [Header("Attack Info")]
    public float power; // 데미지
    public float speed; // 공격할 때의 속도
    public LayerMask target;

    [Header("Knock Back Info")]
    public bool isOnKnockback;
    public float knockbackPower;
    public float knockbackTime;


}
