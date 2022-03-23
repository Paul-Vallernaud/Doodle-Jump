using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb2d;
    void Start()
    {
        rb2d.velocity = transform.right * speed;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
