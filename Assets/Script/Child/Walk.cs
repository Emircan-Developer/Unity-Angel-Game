using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk 
{
    //Customly 7
    int WalkSpeed = 70;
    public Walk(int WalkSpeed)
    {
        this.WalkSpeed = WalkSpeed;
    }
    public Vector2 WalkingVector()
    {
        float x, y;
        x = Input.GetAxis("Horizontal");
        
        return Vector2.right * (x*WalkSpeed);
    }
    public void ChangeSpeed(int WalkSpeed)
    {
        this.WalkSpeed = WalkSpeed;

    }
}
