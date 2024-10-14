using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class JoinBtn : MonoBehaviour
{
    public InputField playerNameInput;
    public string playerName;
    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField>().text;
    }
    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            // 플레이어의 닉네임을 저장
            PlayerPrefs.SetString("PlayerName", playerName);

            // 게임 시작
            SceneManager.LoadScene("MainScene"); //JOIN에 버튼을 만들어 
        }
        else
        {
            Debug.Log("누르긴했니?");
            Debug.Log(playerName);
        }
    }
}