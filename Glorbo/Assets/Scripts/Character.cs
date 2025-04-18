using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class Character : MonoBehaviour {
    public Rigidbody2D body;
    public float moveSpeed;
    public float jumpSpeed;
    private Animator myAnim;
    public Transform groundCheck;
    public float groundCheckRadius; // Radius of groundcheck
    public LayerMask whatIsGround; // What is ground
    public bool isGrounded;
    public int maxHealth;
    public int health;

    void Start() {
        health = maxHealth;
    }

    void Update() {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    public void Move(double magnitude) {
        if (magnitude != 0) {
            //TODO: make this not slow you down if you already going in that direction
            float xvel = (float)(moveSpeed * magnitude);
            body.velocity = new Vector2(xvel, body.velocity.y);
            transform.localScale = new Vector2(Math.Sign(magnitude), 1f);
        }
    }
    public void Jump() {
        if (isGrounded)
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
    }
    public abstract void Interact();
    public abstract void Shoot();
    public abstract void Aim(Vector2 target);
    public abstract void Die();
}
