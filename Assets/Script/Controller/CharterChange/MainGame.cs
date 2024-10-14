using UnityEngine;

public class MainGame : MonoBehaviour
{
    public SpriteRenderer playerSpriteRenderer;  // 플레이어 스프라이트 렌더러

    void Start()
    {
        // GameManager에서 선택된 캐릭터 이미지 불러오기
        Sprite selectedSprite = GameManager.instance.GetSelectedCharacterImage();
        

        // 선택된 캐릭터 스프라이트를 플레이어에 적용
        if (selectedSprite != null)
        {
            playerSpriteRenderer.sprite = selectedSprite;
        }
    }
}
