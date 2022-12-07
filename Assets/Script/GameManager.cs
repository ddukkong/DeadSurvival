using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager instance;
    public GameObject coin0;
    public GameObject coin1;
    public GameObject coin2;
    public Image ExpBar;
    public int NowExp;
    public int MaxExp;
    public int Lcount = 0;

    private void Awake()
    {
        instance = this;
        NowExp = 0;
        
        //ExpBar.fillAmount = 0f;
    }
    void Update()
    {
        MaxLevel();
    }
    public void Exp(int _NowExp) 
    {
        NowExp += _NowExp;
        ExpBar.fillAmount = (float)NowExp / (float) MaxExp;
        //Debug.Log(MaxExp);
    }
    public void MaxLevel()
    {
        if(NowExp >= 100)
        {
            NowExp = 0;
            LevelUI.level += 1; 
            Lcount += 1;
            ExpBar.fillAmount = 0f;
        }
    }
   

}
