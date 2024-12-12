using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Personaje_principal : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2;
    [SerializeField] int altura;
    [SerializeField] Animator animator, Trigger;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2 = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Salto", true);
            rigidbody2.velocity = Vector3.zero;
            rigidbody2.AddForce(Vector3.up * altura);
            audioSource.clip = audioClips[0];
            audioSource.Play();
        }
        else
        {
            animator.SetBool("Caida", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Agacharse");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Salto", false);
        animator.SetBool("Caida", false);
        if (collision.transform.tag == "enemigo")
        {
            gameManager.perder();
        }
    }
}