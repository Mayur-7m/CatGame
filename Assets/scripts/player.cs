using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float Xinput = Input.GetAxis("Horizontal")*speed;
        rb.linearVelocity = new Vector2(Xinput, rb.linearVelocity.y);
    }
}
