using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAAA : MonoBehaviour {
    public Player player;
    private Character target;

    // Start is called before the first frame update
    void Start() {
        target = player;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Jump")) {
            target.Jump();
        }
        print(Input.GetAxisRaw("Horizontal"));
        target.Move(Input.GetAxisRaw("Horizontal"));
    }
}
