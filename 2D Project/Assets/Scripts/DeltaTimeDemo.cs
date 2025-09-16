using UnityEngine;

public class DeltaTimeDemo : MonoBehaviour
{
    [SerializeField]
    GameObject frameObject;

    [SerializeField]
    GameObject deltaObject;

    [SerializeField]
    int frameRate = 60;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = frameRate;

        Vector2 pos = frameObject.transform.position;
        pos.x += 0.01f;
        frameObject.transform.position = pos;

        pos = deltaObject.transform.position;
        pos.x += 0.6f * Time.deltaTime;
        deltaObject.transform.position = pos;

    }
}
