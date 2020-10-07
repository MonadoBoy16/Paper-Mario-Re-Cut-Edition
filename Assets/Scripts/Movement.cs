using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float yVelocity;
    public SpriteRenderer spriteRenderer;
    public int direction;
    public GameObject player;
    public float X;
    public float Y;
    public float IsMoving;
    public UnityEngine.Animator animator;
    public Sprite[] sprites;
    public bool isGrounded;
    Rigidbody rb;

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
}
