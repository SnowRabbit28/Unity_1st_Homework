using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start 씬에서 Main 씬으로 이동
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene"); // Main 씬 이름에 맞게 변경
    }
}
