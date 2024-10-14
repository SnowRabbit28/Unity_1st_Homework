using System;
using UnityEngine;

//몬스터와 캐릭터 둘다 쓰는곳, invoke를 여기서하려고 event를 여기에 만들었다.
public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //누르는 키보드 방향이 있으니 Vector2
    public event Action<Vector2> OnLookEvent; //마우스 방향이 있으니 Vector2


    public void CallMoveEvent(Vector2 direction)
    {

        //Invoke는 약간 지연된 다음 실행, 일정시간 이후 특성 메서드 호출
        OnMoveEvent?.Invoke(direction);// ?.는 있으면 실행 아니면 하지마소
        //OnMoveEvent안에 들어있던 친구들을 invoke해준다. 이함수는 어디서 실행되냐? PlayerInputController에서!
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}