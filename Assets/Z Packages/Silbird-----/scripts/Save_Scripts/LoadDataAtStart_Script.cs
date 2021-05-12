using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadDataAtStart_Script : MonoBehaviour
{

    public Player Player;

    
    void Start()
    {
        Player.LoadPlayer();
        Player.LoadPlayer();
    }
    
}
