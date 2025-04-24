using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void playerTakeControl()
    {
        GetComponent<Player>().enabled = true;
        GetComponent<PlayerControllerAAA>().enabled = true;
        this.enabled = false;
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
