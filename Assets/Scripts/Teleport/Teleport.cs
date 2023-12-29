using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject targetObj; // Player

    public GameObject toObj; // 텔레포트할 위치

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

            if (Input.GetMouseButtonDown(1)) // 마우스 우클릭 시
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
