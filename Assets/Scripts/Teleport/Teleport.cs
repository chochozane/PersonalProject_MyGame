using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetObj; // Player

    public GameObject toObj; // 텔레포트할 위치

    public GameObject teleportMsgPopup;
    public GameObject buttonMsgPopup;

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
            teleportMsgPopup.SetActive(true);

            if (Input.GetMouseButtonDown(1)) // 마우스 우클릭 시
            {
                targetObj.transform.position = toObj.transform.position;
                buttonMsgPopup.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        teleportMsgPopup.SetActive(false);
    }


}
