using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Vector2 moveInput;
    Rigidbody rb;

    void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }


    //�Է� �Ͼ ������ Unity�� �ڵ� ����, �������ִ� ����
    public void Move(InputAction.CallbackContext context)//context = �Է� ����
    {
        moveInput =  context.ReadValue<Vector2>();
    }

    //����
    public void Jump()
    { }

    void HandleMovement()
    {
        Vector3 currentPosition = rb.position;//���� ��ġ
        Vector3 Movement = new Vector3(moveInput.x, 0, moveInput.y);//������ ����

        Vector3 newPosition = currentPosition + Movement * moveSpeed * Time.fixedDeltaTime;//���� + ����������
        rb.MovePosition(newPosition);//�����̱�

    }

}