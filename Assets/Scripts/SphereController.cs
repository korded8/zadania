using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    CharacterController characterController;
    float gravity = -9.81f;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        characterController.Move(move * speed * Time.deltaTime);
        ApplyGravity();
    }

    void ApplyGravity()
    {
        characterController.Move(Vector3.up * gravity * Time.deltaTime);
    }
}
