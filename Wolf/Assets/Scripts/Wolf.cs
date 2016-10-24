using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]

public class Wolf : MonoBehaviour {
    Rigidbody2D rb;
    [SerializeField]
    private bool isFacingRight = true;
 

    public float maxSpeed = 7f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update() {
        
    }

    private void Flip() //пoворачивает персонажа в сторону ходьбы
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void Jump() {
        rb.AddForce(Vector2.up * 350);
    }

    public void Move_right()
    {
        transform.Translate(Vector2.right * Time.deltaTime);


        /*  float move = Input.GetAxis("Horizontal");
        
        if (move > 0 && !isFacingRight)
            Flip();
        else if (move < 0 && isFacingRight)
            Flip();*/
    }
    public void Move_left()
    {
        transform.Translate(Vector2.left * Time.deltaTime);


        /*  float move = Input.GetAxis("Horizontal");
        
        if (move > 0 && !isFacingRight)
            Flip();
        else if (move < 0 && isFacingRight)
            Flip();*/
    }


    /* Проверка, на земле ли герой (потом понадобится)
    public bool IsGrounded()
    {
        if (rb.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }*/

}
