using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarControl : MonoBehaviour
{
    GameObject player;
    BossHP hpcomp;
    Slider hpslider;
    private int hp;
    
    void Start()
    {
        player = GameObject.Find("Boss");
        hpcomp = player.GetComponent<BossHP>();

        hpslider = GameObject.Find("HPBar").GetComponent<Slider>();
        hp = 100;
        hpslider.value = hp;
    }

    void Update()
    {
        int PyHP = hpcomp.HP;
        hpslider.value = PyHP;
    }
}
