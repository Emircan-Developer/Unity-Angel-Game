using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicAttack:Attack
{
    GameObject player;
    GameObject Ammo;
    public MagicAttack(GameObject Ammo,GameObject player)
    {
        this.player = player;
        this.Ammo = Ammo;
    }
    public void Fire()
    {
        GameObject x = GameObject.Instantiate(Ammo, player.transform.right ,Quaternion.identity);
        x.AddComponent<Rigidbody2D>();
        x.transform.position = new Vector2(x.transform.position.x,player.transform.position.y);
        Rigidbody2D rb = x.GetComponent<Rigidbody2D>();
        rb.velocity = player.transform.right * GetSpeed();
        rb.gravityScale = 0;
    }
    public void ChangeAmmo(GameObject Ammo)
    {
        this.Ammo = Ammo;
    }
   
}

