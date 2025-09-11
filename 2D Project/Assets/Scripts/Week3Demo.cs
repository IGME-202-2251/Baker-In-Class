using UnityEngine;
using UnityEngine.InputSystem;

public class Week3Demo : MonoBehaviour
{
    public SpriteRenderer sprite;

    [SerializeField]
    Vector3 spawnPosition;

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
            /*//  Get mouse pos
            spawnPosition = Mouse.current.position.ReadValue();

            spawnPosition = Camera.main.ScreenToWorldPoint(spawnPosition);

            spawnPosition.z = 10;*/

            SpriteRenderer newSR = Instantiate(sprite, spawnPosition, Quaternion.identity);

            newSR.color = Random.ColorHSV(1, 1, 1, 1, 0, 1);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //  Get mouse pos
        spawnPosition = context.ReadValue<Vector2>();

        spawnPosition = Camera.main.ScreenToWorldPoint(spawnPosition);

        spawnPosition.z = 10;
    }
}
