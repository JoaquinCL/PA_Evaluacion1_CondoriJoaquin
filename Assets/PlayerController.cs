using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    public float direccion;
    public float fuerzaSalto;
    public Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
    direccion = Input.GetAxisRaw("Horizontal");
    rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);
    if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}