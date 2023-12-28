using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform Player { get; private set; }
    [SerializeField] private string playerTag = "Player";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this); // ����Scene �̵��� �� GameManager �ı��Ǹ� �� �Ǵϱ� ~
        }
        else
        {
            if (Instance != this) Destroy(this);
        }

        Player = GameObject.FindGameObjectWithTag(playerTag).transform; // todo FindGameObjectWithTag �� ģ�� ������ �� ����� �ɷ� �ƴµ� �ٸ��ɷ� ��ü�� �� �ֳ� �����غ���

    }

    public void ReturnToIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
