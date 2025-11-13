using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectCLcker : MonoBehaviour
{
    RaycastHit hitInfo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        Cursor.lockState = CursorLockMode.Locked;

        if (context.performed)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hitInfo))
            {
                Debug.Log(hitInfo.transform.gameObject.name);
            }
        }
    }
}
