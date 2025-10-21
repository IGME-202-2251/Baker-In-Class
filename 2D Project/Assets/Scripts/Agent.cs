using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    [SerializeField]
    Vector3 position = Vector3.zero;

    [SerializeField]
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    Vector3 acceleration = Vector3.zero;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Zero out Acceleration from last frame
        acceleration = Vector3.zero;

        // Add Steering force to Acceleration
        acceleration += CalcSteeringForces();

        // Update Velocity with current Acceleration
        velocity += acceleration * Time.deltaTime;

        //  Move the agent with Velocity
        transform.position += velocity * Time.deltaTime;
    }

    protected abstract Vector3 CalcSteeringForces();
}
