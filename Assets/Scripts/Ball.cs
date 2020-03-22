﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isPlaying = false;
    public Transform start;
    public Transform yeBrick;
    public Transform beBrick;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
            transform.position = new Vector2(start.position.x, start.position.y + 0.55f);

        if (Input.GetKeyDown(KeyCode.Space) && !isPlaying)
        { 
            isPlaying = true;
            rb.AddForce(Vector2.up * 350);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("down")) 
        {
            rb.velocity = Vector2.zero;
            isPlaying = false; 
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Ybrick")) {

            Transform newExplosion = Instantiate(yeBrick, collision.transform.position,collision.transform.rotation);
            Destroy(newExplosion.gameObject, 2.5f);


            Destroy(collision.gameObject);
        }
       if (collision.transform.CompareTag("Bbrick"))
        {

            Transform newExplosion = Instantiate(beBrick, collision.transform.position, collision.transform.rotation);
            Destroy(newExplosion.gameObject, 2.5f);


            Destroy(collision.gameObject);
        }

    }
}