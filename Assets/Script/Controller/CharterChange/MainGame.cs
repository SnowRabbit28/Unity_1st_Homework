using UnityEngine;

public class MainGame : MonoBehaviour
{
    public SpriteRenderer playerSpriteRenderer;  // �÷��̾� ��������Ʈ ������

    void Start()
    {
        // GameManager���� ���õ� ĳ���� �̹��� �ҷ�����
        Sprite selectedSprite = GameManager.instance.GetSelectedCharacterImage();
        

        // ���õ� ĳ���� ��������Ʈ�� �÷��̾ ����
        if (selectedSprite != null)
        {
            playerSpriteRenderer.sprite = selectedSprite;
        }
    }
}
