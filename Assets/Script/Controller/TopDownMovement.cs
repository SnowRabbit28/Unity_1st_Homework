using UnityEngine;

// TopDownMovement�� ĳ���Ϳ� ������ �̵��� ���� �����Դϴ�.
public class TopDownMovement : MonoBehaviour
{
	private TopDownController movementController;
	private Rigidbody2D movementRigidbody;

	private Vector2 movementDirection = Vector2.zero;

	private void Awake()// �� ������Ʈ�ȿ��� ������ ��
    {
		// ���� ���ӿ�����Ʈ�� TopDownController, Rigidbody�� ������ �� 
		movementController = GetComponent<TopDownController>();
		movementRigidbody = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		// OnMoveEvent�� Move��� �Լ��� ȣ���϶�� �����
		movementController.OnMoveEvent += Move;
	}

	private void FixedUpdate()
	{
		// ���� ������Ʈ���� ���������� ����
		ApplyMovement(movementDirection);
	}

	private void Move(Vector2 direction)
	{
		// �̵����⸸ ���صΰ� ������ ���������� ����.
		// �����̴� ���� ���� ������Ʈ���� ����(rigidbody�� �����ϱ�)
		movementDirection = direction;
	}

	private void ApplyMovement(Vector2 direction)
	{
		direction = direction * 5;
        //Velocity : rigidbody�� �ӵ��� ��Ÿ���ϴ�. velocity�� �����ϸ� ������Ʈ�� ������ ������� ���� �ӵ��� �ݴϴ�.
        movementRigidbody.velocity = direction;
	}
}