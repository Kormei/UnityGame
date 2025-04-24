using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Rigidbody rigidbod;
    void Start()
    {
        rigidbod = GetComponent<Rigidbody>();
    }
    // Impulse ball towards the center of the table considering player position
    public void BallHit(Vector3 directionFrom, Vector3 target, float strength)
    {
        Vector3 direction = (target - directionFrom).normalized;
        direction.y = .375f;
        rigidbod.velocity = Vector3.zero;
        rigidbod.AddForce(direction * strength, ForceMode.Impulse);
        rigidbod.useGravity = true;
    }
}
