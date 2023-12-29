using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "TopDownCharacterController/Attacks/Default", order = 0)]
public class AttackSO : ScriptableObject
{
    [Header("Attack Info")]
    public float power; // ������
    public float speed; // ������ ���� �ӵ�
    public LayerMask target;

    [Header("Knock Back Info")]
    public bool isOnKnockback;
    public float knockbackPower;
    public float knockbackTime;


}
