using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5;

    Vector3 moveDirection = Vector3.zero;
    Vector3 velocity = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDirection != Vector3.zero)
        {
            velocity = transform.right * moveDirection.x;

            velocity += transform.forward * moveDirection.y;

            Debug.Log(velocity.sqrMagnitude);

            transform.position += velocity * moveSpeed * Time.deltaTime;
        }
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }
}
