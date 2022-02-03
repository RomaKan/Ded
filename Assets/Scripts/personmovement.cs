using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.UI;
public class personmovement : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D li;
    public float moveSpeed = 5f;
    float dirX;
    int defolt;
    public Rigidbody2D rb;
    public Animator animator;
    private bool isMoving = false;
    public float diag = 1;
    Vector2 movement;
    bool fonar=false;
    AnimationState state;
    public Transform fonarik;
    public SpriteRenderer render;
    public GameObject Invent;
    private int count = 0;
    void Start()
    {
        
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        animator.SetInteger("Def", defolt);
        animator.SetBool("fonar", fonar);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        diag = 1;
        if (movement.x != 0 || movement.y != 0)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (movement.x != 0 && movement.y != 0)
        {
            diag = 1.41421f;
        }
        if (isMoving)
        {
            count++;
            if (count == 1)
            {
                FindObjectOfType<AudioManager>().PlayIt("Hotba");
            }
        }
        else if (!isMoving)
        {
            count = 0;
            FindObjectOfType<AudioManager>().StopIt("Hotba");
        }

    }



    void FixedUpdate()
    {
       
        if (Input.GetKeyDown(KeyCode.F) && movement.y==0 && movement.x==0)
        {
            fonar = !fonar;
            li.enabled = !li.enabled;
        }
        if (Input.GetKeyDown(KeyCode.I) )
        {
            Invent.SetActive(!Invent.activeSelf);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("fonar_left_def")) {
            fonarik.position = new Vector2(rb.transform.position.x - 0.0868f, rb.transform.position.y+ 0.1166f);
            
        }
        
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("fonar_right_def"))
        {
            fonarik.position = new Vector2(rb.transform.position.x +0.0693f, rb.transform.position.y + 0.1114f);
           
        }
        
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("fonar_up_def"))
        {
            fonarik.position = new Vector2(rb.transform.position.x + 0.0917f, rb.transform.position.y + 0.0852f);
            
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("fonar_down_def"))
        {
            //li.enabled = true;
            fonarik.position = new Vector2(rb.transform.position.x + -0.085f, rb.transform.position.y + 0.084f);

        }
       
        switch (render.sprite.name)
        {
            case "Fonar_20": fonarik.position = new Vector2(rb.transform.position.x - 0.0999f, rb.transform.position.y + 0.113f);
                break;
            case "Fonar_21":
                fonarik.position = new Vector2(rb.transform.position.x - 0.1011f, rb.transform.position.y + 0.1023f);
                break;
            case "Fonar_22":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0947f, rb.transform.position.y + 0.0999f);
                break;
            case "Fonar_23":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0787f, rb.transform.position.y + 0.0991f);
                break;
            case "Fonar_24":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0848f, rb.transform.position.y + 0.1029f);
                break;
            case "Fonar_25":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0947f, rb.transform.position.y + 0.1151f);
                break;
            case "Fonar_26":
                fonarik.position = new Vector2(rb.transform.position.x + 0.1001f, rb.transform.position.y + 0.1171f);
                break;
            case "Fonar_27":
                fonarik.position = new Vector2(rb.transform.position.x + 0.1044f, rb.transform.position.y + 0.1013f);
                break;
            case "Fonar_28":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0936f, rb.transform.position.y + 0.1035f);
                break;
            case "Fonar_29":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0785f, rb.transform.position.y + 0.1028f);
                break;
            case "Fonar_30":
                fonarik.position = new Vector2(rb.transform.position.x + 0.085f, rb.transform.position.y + 0.1028f);
                break;
            case "Fonar_31":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0943f, rb.transform.position.y + 0.1143f);
                break;
            case "Fonar_8":
                fonarik.position = new Vector2(rb.transform.position.x -0.0857f, rb.transform.position.y + 0.08399999f);
                break;
            case "Fonar_9":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0857f, rb.transform.position.y + 0.0749f);
                break;
            case "Fonar_10":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0857f, rb.transform.position.y + 0.0749f);
                break;
            case "Fonar_11":
                fonarik.position = new Vector2(rb.transform.position.x - 0.0805f, rb.transform.position.y + 0.0846f);
                break;
            case "Fonar_12":
                fonarik.position = new Vector2(rb.transform.position.x - 0.085f, rb.transform.position.y + 0.0736f);
                break;
            case "Fonar_13":
                fonarik.position = new Vector2(rb.transform.position.x - 0.084f, rb.transform.position.y + 0.0732f);
                break;
            case "Fonar_14":
                fonarik.position = new Vector2(rb.transform.position.x+ 0.086f, rb.transform.position.y + 0.0852f);
                break;
            case "Fonar_15":
                fonarik.position = new Vector2(rb.transform.position.x + 0.086f, rb.transform.position.y + 0.0727f);
                break;
            case "Fonar_16":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0843f, rb.transform.position.y + 0.0721f);
                break;
            case "Fonar_17":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0775f, rb.transform.position.y + 0.0829f);
                break;
            case "Fonar_18":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0849f, rb.transform.position.y + 0.0738f);
                break;
            case "Fonar_19":
                fonarik.position = new Vector2(rb.transform.position.x + 0.0849f, rb.transform.position.y + 0.0727f);
                break;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime / diag);
        if (movement.x>0)
        {
            defolt = 1;
        }
        if (movement.x < 0)
        {
            defolt = 2;
        }
        if (movement.y > 0)
        {
            defolt = 3;
        }
        if (movement.y < 0)
        {
            defolt = 4;
        }
    }
}
