using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    bool can = true;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D col)
    {
        if (can)
        {
            int x = Random.Range(2, 7);
            col.gameObject.GetComponent<move_player>().Give_money(x);
            can = false;
            anim.Play("chest");
        }
    }

    // 
}
