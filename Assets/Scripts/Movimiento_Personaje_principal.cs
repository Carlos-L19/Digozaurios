using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Personaje_principal : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2;
    [SerializeField] int altura;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Salto", true);
            rigidbody2.velocity = Vector3.zero;
            rigidbody2.AddForce(Vector3.up * altura);
        }
        else
        {
            animator.SetBool("Caida", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Salto", false);
        animator.SetBool("Caida", false);
    }
}