using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Rigidbody rigidbod;
    void Start()
    {
        rigidbod = GetComponent<Rigidbody>();
    }
    // Impulse ball in the direction from player to ball
    public void BallHit(Vector3 directionFrom, float strength)
    {
        Vector3 direction = (transform.position - directionFrom).normalized;
        rigidbod.AddForce(direction * strength, ForceMode.Impulse);
    }
}
