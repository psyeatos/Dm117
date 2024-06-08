using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float velocidadeInicial = 25.0f;
    public GameObject bullet;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Define a velocidade inicial da bala na direção que ela está apontando
        rb.velocity = transform.right * velocidadeInicial;
    }

    private void Update()
    {
        if (transform.position.y <= -50)
        {
            Destroy(gameObject);
        }
    }

}
