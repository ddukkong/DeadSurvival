using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float Speed;
    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;

    public int maxHP;
    public int nowHP;
    public Image nowHpBar;
    private Camera theCam;

    public Transform firePoint;
    public GameObject bulletToFire;


    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        nowHP = maxHP;
        theCam = Camera.main;
    }

    void Update()
    {
        nowHpBar.fillAmount = (float)nowHP / (float)maxHP;

        Vector3 mouse = Input.mousePosition;

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);

        Vector2 offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletToFire, firePoint.position, transform.rotation);
        }
    }
    void FixedUpdate()
    {
        Vector2 nextVec = inputVec * Speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);

    }
    private void LateUpdate()
    {
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
        anim.SetFloat("Speed", inputVec.magnitude);
    }
    void OnMove(InputValue value)
    {
        
        inputVec = value.Get<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            nowHP -= 1;
            if (nowHP <= 0)
            {
                Destroy(gameObject);
                Destroy(nowHpBar.gameObject);
                anim.SetBool("Dead", true);
                SceneManager.LoadScene(2);

            }
        }
    }
    private void OnTriggerStay2D(Collider2D col)
    {

        if (col.CompareTag("Enemy"))
        {
            nowHP -= 1;

            if (nowHP <= 0)
            {
                Destroy(gameObject);
                Destroy(nowHpBar.gameObject);
                anim.SetBool("Dead", true);
                SceneManager.LoadScene(2);
            }

        }


    }



}
