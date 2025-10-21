using UnityEngine;

public class Seeker : Agent
{
    protected override Vector3 CalcSteeringForces()
    {
        return Vector3.zero;
    }
}
