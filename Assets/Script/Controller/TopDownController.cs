using System;
using UnityEngine;

//���Ϳ� ĳ���� �Ѵ� ���°�, invoke�� ���⼭�Ϸ��� event�� ���⿡ �������.
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //������ Ű���� ������ ������ Vector2
    public event Action<Vector2> OnLookEvent; //���콺 ������ ������ Vector2


    public void CallMoveEvent(Vector2 direction)
    {

        //Invoke�� �ణ ������ ���� ����, �����ð� ���� Ư�� �޼��� ȣ��
        OnMoveEvent?.Invoke(direction);// ?.�� ������ ���� �ƴϸ� ��������
        //OnMoveEvent�ȿ� ����ִ� ģ������ invoke���ش�. ���Լ��� ��� ����ǳ�? PlayerInputController����!
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}