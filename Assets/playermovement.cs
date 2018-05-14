using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : SingletonMonoBehavior<playermovement> {
    public Vector2 moveForce;
    Rigidbody playerRB;

    // Use this for initialization
    void Start() {
        playerRB = GetComponent<Rigidbody>();
    }

    public void changeMoveForceX(int x) {
        moveForce = new Vector2(x,moveForce.y);
    }
    public void changeMoveForceY(int y) {
        moveForce = new Vector2(moveForce.x,y);
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        playerRB.velocity += transform.rotation*(new Vector3(moveHorizontal,0.0f, moveVertical) * 20*Time.deltaTime) ;
        //playerRB.AddForce(new Vector3(moveHorizontal,0, moveVertical) * 100 * Time.deltaTime);
    }
}
