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
            // �÷��̾��� �г����� ����
            PlayerPrefs.SetString("PlayerName", playerName);

            // ���� ����
            SceneManager.LoadScene("MainScene"); //JOIN�� ��ư�� ����� 
        }
        else
        {
            Debug.Log("�������ߴ�?");
            Debug.Log(playerName);
        }
    }
}