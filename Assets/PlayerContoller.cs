using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    Vector2 moveInput;

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log($"OnMove 호출됨: {moveInput}"); // 디버깅용
    }

    void Update()
    {
        // 3D 이동: x축, z축만 사용 (y축 고정)
        transform.Translate(moveInput.x * moveSpeed * Time.deltaTime, 0, moveInput.y * moveSpeed * Time.deltaTime);
    }
}