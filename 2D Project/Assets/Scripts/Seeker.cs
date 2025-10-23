using UnityEngine;

public class Seeker : Agent
{
    public GameObject target;

    [SerializeField]
    float targetSeekWeight, mouseSeekWeight;


    protected override Vector3 CalcSteeringForces()
    {
        Vector3 ultimaForce = Vector3.zero;

        ultimaForce += Seek(target) * targetSeekWeight;

        Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = 0;
        ultimaForce += Seek(targetPos) * mouseSeekWeight;
        

        return ultimaForce;
    }
}
