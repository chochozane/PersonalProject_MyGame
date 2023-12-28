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
            DontDestroyOnLoad(this); // 게임Scene 이동할 때 GameManager 파괴되면 안 되니까 ~
        }
        else
        {
            if (Instance != this) Destroy(this);
        }

        Player = GameObject.FindGameObjectWithTag(playerTag).transform; // todo FindGameObjectWithTag 이 친구 연산이 꽤 헤비한 걸로 아는데 다른걸로 대체할 수 있나 생각해보기

    }

    public void ReturnToIntro()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
