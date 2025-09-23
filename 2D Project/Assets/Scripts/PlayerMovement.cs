using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    Vector2 movementDirection;

    [SerializeField]
    Vector3 velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  calc velocity
        velocity = movementDirection * speed * Time.deltaTime;

        //  move GameObject
        transform.position += velocity;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }
}
