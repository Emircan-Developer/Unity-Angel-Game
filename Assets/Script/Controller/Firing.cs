using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public GameObject player;
    public GameObject Ammo;
    MagicAttack attack;
    Anim anim;
    private void Awake()
    {
        //player = GetComponent<GameObject>();
        attack = new MagicAttack(Ammo,player);
        attack.SetSpeed(10);
        anim = new Anim(GetComponent<Animator>());
    }
    // Start is called before the first frame update
    void Start()
    {
         attack.SetDamage(10);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.Fire();
            anim.Attack();
        }
    }
}
