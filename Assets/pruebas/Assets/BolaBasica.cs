﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaBasica : MonoBehaviour
{
    Rigidbody2D rb;
    CircleCollider2D colliderBola;
    public float velocidad = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        colliderBola = GetComponent<CircleCollider2D>();
        //rb.AddForce(Vector2.up*velocidad);
        colliderBola.isTrigger = false;
    }



    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Bloque"))
        {
            Destroy(col.gameObject);
        }
    }
}
