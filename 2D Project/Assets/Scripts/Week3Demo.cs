using UnityEngine;
using UnityEngine.InputSystem;

public class Week3Demo : MonoBehaviour
{
    public SpriteRenderer sprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Canceled)
        {
            SpriteRenderer newSR = Instantiate(sprite, transform.position, Quaternion.identity);
            newSR.color = Random.ColorHSV(1, 1, 1, 1, 0, 1);
        }
    }

    public void JumpyJump(InputAction.CallbackContext randomStuff)
    {

    }
}
