using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Camera playerCamera;

    [SerializeField]
    Vector2 mouseInput;

    [SerializeField]
    Vector2 lookSensitifity = Vector2.one;

    Quaternion lookRotation;

    [SerializeField]
    float maxLookUpAngle = 70f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTurn(InputAction.CallbackContext context)
    {
        mouseInput = context.ReadValue<Vector2>();

        //  Turn left/right
        transform.rotation = transform.rotation * Quaternion.Euler(0f, mouseInput.x * lookSensitifity.x, 0f);

        //  Look up/down
        lookRotation = playerCamera.transform.rotation * Quaternion.Euler(mouseInput.y * lookSensitifity.y, 0f, 0f);

        /*if(lookRotation.eulerAngles.x > maxLookUpAngle)
        {
            lookRotation = Quaternion.Euler(maxLookUpAngle, 0f, 0f);
        }
        else if (lookRotation.eulerAngles.x < -maxLookUpAngle)
        {
            lookRotation = Quaternion.Euler(-maxLookUpAngle, 0f, 0f);
        }*/

        playerCamera.transform.rotation = lookRotation;
    }
}
