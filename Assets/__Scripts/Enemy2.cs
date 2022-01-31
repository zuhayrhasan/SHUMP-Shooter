using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    private float ran;
    
    void Start() {
        // Sets "ran" to either 0 or 1
        ran = (Random.Range(0, 2));
    }

    public override void Move() {
        // If "ran" = 0, the object will go towards the right, otherwise it will go left
        if (ran==0) {
            Vector3 tempPos = pos;
            tempPos.y -= speed * Time.deltaTime;
            tempPos.x += speed * Time.deltaTime;
            pos = tempPos;
        } else {
            Vector3 tempPos = pos;
            tempPos.y -= speed * Time.deltaTime;
            tempPos.x -= speed * Time.deltaTime;
            pos = tempPos;
        }

        base.Move();
    }
}
