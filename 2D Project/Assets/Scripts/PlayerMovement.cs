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

    [SerializeField]
    Rigidbody2D rbody2D;

    public bool usePhysics = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!usePhysics)
        {
            //  calc velocity
            velocity = movementDirection * speed * Time.deltaTime;

            //  move GameObject
            transform.position += velocity;
        }
    }

    private void FixedUpdate()
    {
        if (usePhysics)
        {
            //  calc velocity
            velocity = movementDirection * speed * Time.fixedDeltaTime;

            //  move GameObject
            rbody2D.MovePosition(transform.position + velocity);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
