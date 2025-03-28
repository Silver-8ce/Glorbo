using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Movement {
    private Rigidbody2D body;
    void Move(double magnitude);
    void Jump();
    void Interact();
    void Shoot();
    void Aim(Vector2 target);
}
