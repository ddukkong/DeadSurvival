using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coin;

    private void Start()
    {

    }
    void Update()
    {
        
    }

    
    public void UseCoin()
    {
        
        GameManager.instance.Exp(coin);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.CompareTag("Player"))
        {
            UseCoin();
        }
        
    }

}
