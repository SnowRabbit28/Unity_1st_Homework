using UnityEngine;
using UnityEngine.UI;  // UI 요소에 접근하기 위해 필요

public class CharacterSelection : MonoBehaviour
{
    public GameObject characterSelectionPanel; // 캐릭터 선택 패널
    public Image playerImage;  // 선택된 캐릭터 스프라이트를 적용할 플레이어 이미지
    public Button selectcharacterButton; // 버튼
    public Text text;

    // 캐릭터 선택 패널 열기
    public void OpenSelectionPanel()
    {
        characterSelectionPanel.SetActive(true); // 패널 활성화
        text.gameObject.SetActive(false);
    }

    // 캐릭터 선택 후 저장 및 캐릭터 이미지 설정
    public void SelectCharacter(Button characterButton)
    {

        if (characterButton == null)
        {
            Debug.LogError("Character Button is null!");
            return;
        }

        // 버튼의 이미지 가져오기
        //Image buttonImage = characterButton.GetComponent<Image>();
        Image buttonImage = characterButton.GetComponentInChildren<Image>();

        // 선택된 캐릭터 이미지를 플레이어 이미지에 적용
        //playerImage.sprite = buttonImage.sprite;
        selectcharacterButton.GetComponent<Image>().sprite = buttonImage.sprite;

        // 선택된 캐릭터 정보를 싱글톤에 저장
        GameManager.instance.SetSelectedCharacterImage(buttonImage.sprite);

        // 캐릭터 선택창 비활성화
        characterSelectionPanel.SetActive(false);
    }
}