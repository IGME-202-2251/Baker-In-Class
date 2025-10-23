using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    Vector3 position = Vector3.zero;

    Vector3 velocity = Vector3.zero;

    Vector3 acceleration = Vector3.zero;

    [SerializeField]
    float maxSpeed = 5f;

    [SerializeField]
    float maxForce = 5f;

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

        acceleration = Vector3.ClampMagnitude(acceleration, maxForce);

        // Update Velocity with current Acceleration
        velocity += acceleration * Time.deltaTime;

        //  Move the agent with Velocity
        transform.position += velocity * Time.deltaTime;
    }

    protected abstract Vector3 CalcSteeringForces();


    //
    //  Steering Behaviors
    //
    protected Vector3 Seek(Vector3 targetPos)
    {
        // Calculate desired velocity
        Vector3 desiredVelocity = targetPos - transform.position;

        // Set desired = max speed
        desiredVelocity = desiredVelocity.normalized * maxSpeed;

        // Calculate seek steering force
        Vector3 seekingForce = desiredVelocity - velocity;

        // Return seek steering force
        return seekingForce;
    }

    protected Vector3 Seek(GameObject targetObj)
    {
        return Seek(targetObj.transform.position);
    }
}
