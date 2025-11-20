using UnityEngine;

public class GroundSnappingController : MonoBehaviour
{
    RaycastHit hitInfo;

    [SerializeField]
    LayerMask goundLayerMask;

    [SerializeField]
    float yOffset = 2f;

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, -transform.up, out hitInfo, Mathf.Infinity, goundLayerMask))
        {
            Vector3 snapPoint = hitInfo.point;
            snapPoint.y += yOffset;

            //  Snap to ground
            transform.position = snapPoint;
        }
    }
}
