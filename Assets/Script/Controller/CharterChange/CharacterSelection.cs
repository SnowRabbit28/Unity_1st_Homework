using UnityEngine;
using UnityEngine.UI;  // UI ��ҿ� �����ϱ� ���� �ʿ�

public class CharacterSelection : MonoBehaviour
{
    public GameObject characterSelectionPanel; // ĳ���� ���� �г�
    public Image playerImage;  // ���õ� ĳ���� ��������Ʈ�� ������ �÷��̾� �̹���
    public Button selectcharacterButton; // ��ư
    public Text text;

    // ĳ���� ���� �г� ����
    public void OpenSelectionPanel()
    {
        characterSelectionPanel.SetActive(true); // �г� Ȱ��ȭ
        text.gameObject.SetActive(false);
    }

    // ĳ���� ���� �� ���� �� ĳ���� �̹��� ����
    public void SelectCharacter(Button characterButton)
    {

        if (characterButton == null)
        {
            Debug.LogError("Character Button is null!");
            return;
        }

        // ��ư�� �̹��� ��������
        //Image buttonImage = characterButton.GetComponent<Image>();
        Image buttonImage = characterButton.GetComponentInChildren<Image>();

        // ���õ� ĳ���� �̹����� �÷��̾� �̹����� ����
        //playerImage.sprite = buttonImage.sprite;
        selectcharacterButton.GetComponent<Image>().sprite = buttonImage.sprite;

        // ���õ� ĳ���� ������ �̱��濡 ����
        GameManager.instance.SetSelectedCharacterImage(buttonImage.sprite);

        // ĳ���� ����â ��Ȱ��ȭ
        characterSelectionPanel.SetActive(false);
    }
}