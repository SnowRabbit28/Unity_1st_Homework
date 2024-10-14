using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; //메인카메라태그 붙어있는 카메라를 가져온다.
    }

    public void OnMove(InputValue value)
    { //왜 onMove를 또 만들어서 여기서 call을해주냐면, 정규화도하고, 마우스 위치도 월드화 해야해서/ 전처리 위해서
        Vector2 moveInput = value.Get<Vector2>().normalized;//크기가 1인벡터
        CallMoveEvent(moveInput);// 상속받은거라서 잘 쓸수있다.
    }

    public void OnLook(InputValue value)
    {   //수많은 범위중에 월드좌표를 알아야한다. 근데 알려면 카메라가 어딜 띄우는지 알아야하니 camera.이 들어가야한다.
        Vector2 newAim = value.Get<Vector2>(); //마우스 이동에 따라 움직여야해서 정규화 x
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//마우스는 화면에 있어서 월드에있는 좌표 맞추기
        newAim = (worldPos - (Vector2)transform.position).normalized; //캐릭터와 월드좌표의 거리를 계산한것

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