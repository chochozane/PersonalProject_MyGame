using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetObj; // Player

    public GameObject toObj; // �ڷ���Ʈ�� ��ġ

    public GameObject msgPopup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            targetObj = collision.gameObject;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            msgPopup.SetActive(true);

            if (Input.GetMouseButtonDown(1)) // ���콺 ��Ŭ�� ��
            {
                targetObj.transform.position = toObj.transform.position;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        msgPopup.SetActive(false);
    }


}
