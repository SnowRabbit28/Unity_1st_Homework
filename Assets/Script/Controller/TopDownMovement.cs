using UnityEngine;

// TopDownMovement는 캐릭터와 몬스터의 이동에 사용될 예정입니다.
public class TopDownMovement : MonoBehaviour
{
	private TopDownController movementController;
	private Rigidbody2D movementRigidbody;

	private Vector2 movementDirection = Vector2.zero;

	private void Awake()// 내 컴포넌트안에서 끝나는 것
    {
		// 같은 게임오브젝트의 TopDownController, Rigidbody를 가져올 것 
		movementController = GetComponent<TopDownController>();
		movementRigidbody = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		// OnMoveEvent에 Move라는 함수를 호출하라고 등록함
		movementController.OnMoveEvent += Move;
	}

	private void FixedUpdate()
	{
		// 물리 업데이트에서 실제움직임 적용
		ApplyMovement(movementDirection);
	}

	private void Move(Vector2 direction)
	{
		// 이동방향만 정해두고 실제로 움직이지는 않음.
		// 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
		movementDirection = direction;
	}

	private void ApplyMovement(Vector2 direction)
	{
		direction = direction * 5;
        //Velocity : rigidbody의 속도를 나타냅니다. velocity를 지정하면 오브젝트의 질량과 상관없이 일정 속도를 줍니다.
        movementRigidbody.velocity = direction;
	}
}