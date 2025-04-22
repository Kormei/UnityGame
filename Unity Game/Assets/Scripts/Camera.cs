using UnityEngine;

public class Camera : MonoBehaviour
{
    private float smoothTime = .25f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField]private Transform target;
    // Update is called once per frame
    void Update()
    {
        Vector3 followDistance = new Vector3(0f, 3.8f, -2.3f);
        if(target.position.z < -7){followDistance = new Vector3(0f, 1.5f - target.position.z/3, 3.5f + target.position.z * 5/6);}
        Vector3 targetPosition = target.position + followDistance;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
