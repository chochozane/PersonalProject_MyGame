using UnityEngine;

public class EndingButton : MonoBehaviour
{
    
    [SerializeField] private GameObject endingPopup;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") )
        {
            endingPopup.SetActive(true);
        }
    }
}
