using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack
{
    int GetDamage();
  
    void SetDamage(int Damage);

    int GetSpeed();

    void SetSpeed(int Speed);
}
