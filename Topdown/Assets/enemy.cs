using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public int maxHeatlh = 1;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHeatlh;
        speed = Random.Range(3f, 10f);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);
    }
    void Update()
    {
        if (transform.position.y < -6 || transform.position.x < -4 || transform.position.x > 4 || currentHealth <= 0)  
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            TakeDamage(1);
            score.scoreValue++;
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
