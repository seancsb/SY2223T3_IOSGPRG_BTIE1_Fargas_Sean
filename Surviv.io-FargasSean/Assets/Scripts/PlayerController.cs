using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class PlayerController : MonoBehaviour
{
    // Movement Inputs
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private FixedJoystick leftJoyStick;
    [SerializeField] private FixedJoystick rightJoyStick;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotationSpeed;

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(leftJoyStick.Horizontal * moveSpeed, leftJoyStick.Vertical * moveSpeed);

        Vector2 playerRotation = new Vector2(rightJoyStick.Horizontal * moveSpeed, rightJoyStick.Vertical * moveSpeed);

        Quaternion toRotation = Quaternion.LookRotation(transform.forward, playerRotation);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);

        //rb.MoveRotation(transform.rotation);
    }
}
