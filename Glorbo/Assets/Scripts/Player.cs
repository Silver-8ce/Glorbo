using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public new void Move(double magnitude) {
        base.Move(magnitude);
    }
    public new void Jump() {
        base.Jump();
    }
    public override void Interact() {
        
    }
    public override void Shoot() {
        
    }
    public override void Aim(Vector2 target) {
        
    }
    public override void Die() {
        
    }
}
