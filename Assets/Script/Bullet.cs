using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public int dmg = 50;
    public float speed = 10f;
    public Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.right * speed;
        Invoke("Del", 4f);
        
    }
    void Del()
    {
        Destroy(gameObject);

    }















}
