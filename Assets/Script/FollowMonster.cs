using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class FollowMonster : MonoBehaviour
{

    public float speed;
   
    private Transform target;

    public int MmaxHP = 100;
    public int MnowHP;

    public Image MnowHpBar;
    public Sprite[] sprites;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;


   

    private void Awake()
    {
        MnowHP = MmaxHP;
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {
        MnowHpBar.fillAmount = (float)MnowHP / (float)MmaxHP;
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
    }
    void onHit(int dmg)
    {
        MnowHP -= dmg;
        if (MnowHP <= 0)
        {
            Destroy(gameObject);

            Die();
            DeathUI.deathCount += 1;
        }
        //spriteRenderer.sprite = sprites[1];
        //Invoke("Returnsprite", 0.1f);



    }

    //void Returnsprite()
    //{
    //    spriteRenderer.sprite = sprites[0];
    //}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Bullet"))
        {
            
            Bullet bullet = col.gameObject.GetComponent<Bullet>();
            onHit(bullet.dmg);
        }
    }
    public void Die()
    {
        float rand = Random.Range(0, 1f);

        if (rand < 0.5f)
        {
            
            var instance2 = Instantiate(GameManager.instance.coin0); // 코인을 생성
            instance2.transform.position = transform.position; // 죽은 위치에서 생성
           
        }
        else if (rand < 0.85f)
        {
            var instance2 = Instantiate(GameManager.instance.coin1); // 코인을 생성
            instance2.transform.position = transform.position; // 죽은 위치에서 생성

        }
        else
        {
            var instance2 = Instantiate(GameManager.instance.coin2); // 코인을 생성
            instance2.transform.position = transform.position; // 죽은 위치에서 생성
        }

        /*Destroy(GameManager.instance.coin0.gameObject, 3f);
        Destroy(GameManager.instance.coin1.gameObject, 3f);
        Destroy(GameManager.instance.coin2.gameObject, 3f);*/

    }
    

}
