using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy_items : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public void buy(int cost)
    {   
        int x = player.GetComponent<move_player>().money;
        if (x >= -cost)
            player.GetComponent<move_player>().Give_money(cost);
    }

}
