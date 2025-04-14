using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Opponent : MonoBehaviour
{
    float speed = 2;
    [SerializeField]Ball ball;
    Vector3 targetPosition;
    public Transform oppTarget;
    void Start()
    {
        targetPosition = transform.position;
    }

    // Keep opponent in line with ball
    void Update()
    {
        targetPosition.x = ball.transform.position.x;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            ball.BallHit(oppTarget.position, .3f);
        }
    }
}
