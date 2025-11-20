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
            Vector3 snapPoint = transform.position;
            snapPoint.y = hitInfo.point.y + yOffset;

            //  Snap to ground
            transform.position = snapPoint;

            //  Align with ground
            Vector3 newForward = Vector3.Cross(transform.right, hitInfo.normal);

            transform.LookAt(transform.position + newForward, hitInfo.normal);
        }
    }
}
