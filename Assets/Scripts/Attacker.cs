using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    // Clamps move speed
    // Gives a slider in Unity!
    [Range(0f, 5f)]
    private float _currentSpeed = 0f;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        _currentSpeed = speed;
    }
}
