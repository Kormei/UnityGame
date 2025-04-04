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
        Vector3 direction = (target - transform.position + (transform.position - directionFrom)/2).normalized;
        direction.y = 0;
        rigidbod.velocity = new Vector3(0, 0, 0);
        rigidbod.AddForce(direction * strength, ForceMode.Impulse);
    }
}
