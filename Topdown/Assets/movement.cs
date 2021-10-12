using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    public int maxHeatlh = 1;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHeatlh;
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(player);
        }
    }
    void FixedUpdate()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            TakeDamage(1);
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
