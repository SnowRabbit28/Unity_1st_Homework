using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // ���õ� ĳ���� ��������Ʈ�� ������ ����
    public Sprite selectedCharacterSprite;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // ���� ��ȯ�Ǿ �������� �ʵ��� ����
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ĳ���� ���� �̹��� ����, ��ư���� �ٲܷ�
    public void SetSelectedCharacterImage(Sprite sprite)
    {
        selectedCharacterSprite = sprite;
    }

    // ���õ� ĳ���� ��������Ʈ ��ȯ
    public Sprite GetSelectedCharacterImage()
    {
        return selectedCharacterSprite;
    }
}
