using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : IAttack
{
    private int Damage;

    private int Speed;
    public int GetDamage()
    {
        return Damage;
    }

    public int GetSpeed()
    {
        return Speed;
    }

    public void SetDamage(int Damage)
    {
        this.Damage = Damage;
    }

    public void SetSpeed(int Speed)
    {
        this.Speed = Speed;
    }
}
