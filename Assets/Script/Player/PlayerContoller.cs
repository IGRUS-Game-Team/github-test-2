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


    //입력 일어날 때마다 Unity가 자동 생성, 전달해주는 정보
    public void Move(InputAction.CallbackContext context)//context = 입력 정보
    {
        moveInput =  context.ReadValue<Vector2>();
    }

    //점프
    public void Jump()
    { }

    void HandleMovement()
    {
        Vector3 currentPosition = rb.position;//현재 위치
        Vector3 Movement = new Vector3(moveInput.x, 0, moveInput.y);//움직인 정도

        Vector3 newPosition = currentPosition + Movement * moveSpeed * Time.fixedDeltaTime;//현재 + 움직인정도
        rb.MovePosition(newPosition);//움직이기

    }

}