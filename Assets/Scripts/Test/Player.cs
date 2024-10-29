using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: IAttack
{
    public int Damage { get; set; }

    public void Attack()
    {
        Damage = 2;
    }

    // int playerHp;
    // public int playerHp
    // {
    //     get { return playerHp; }
    //     set { playerHp = value; }
    // }

    // //string playerName;
    // public string PlayerName { get; set; }

    
}
