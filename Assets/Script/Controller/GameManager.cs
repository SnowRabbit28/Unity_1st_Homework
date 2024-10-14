using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // 선택된 캐릭터 스프라이트를 저장할 변수
    public Sprite selectedCharacterSprite;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // 씬이 전환되어도 삭제되지 않도록 설정
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 캐릭터 선택 이미지 저장, 버튼으로 바꿀래
    public void SetSelectedCharacterImage(Sprite sprite)
    {
        selectedCharacterSprite = sprite;
    }

    // 선택된 캐릭터 스프라이트 반환
    public Sprite GetSelectedCharacterImage()
    {
        return selectedCharacterSprite;
    }
}
