using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; //����ī�޶��±� �پ��ִ� ī�޶� �����´�.
    }

    public void OnMove(InputValue value)
    { //�� onMove�� �� ���� ���⼭ call�����ֳĸ�, ����ȭ���ϰ�, ���콺 ��ġ�� ����ȭ �ؾ��ؼ�/ ��ó�� ���ؼ�
        Vector2 moveInput = value.Get<Vector2>().normalized;//ũ�Ⱑ 1�κ���
        CallMoveEvent(moveInput);// ��ӹ����Ŷ� �� �����ִ�.
    }

    public void OnLook(InputValue value)
    {   //������ �����߿� ������ǥ�� �˾ƾ��Ѵ�. �ٵ� �˷��� ī�޶� ��� ������ �˾ƾ��ϴ� camera.�� �����Ѵ�.
        Vector2 newAim = value.Get<Vector2>(); //���콺 �̵��� ���� ���������ؼ� ����ȭ x
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//���콺�� ȭ�鿡 �־ ���忡�ִ� ��ǥ ���߱�
        newAim = (worldPos - (Vector2)transform.position).normalized; //ĳ���Ϳ� ������ǥ�� �Ÿ��� ����Ѱ�

        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
}