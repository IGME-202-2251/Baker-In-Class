using UnityEngine;

public class Seeker : Agent
{
    public GameObject target;


    protected override Vector3 CalcSteeringForces()
    {
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;

        return Seek(targetPos);
    }
}
