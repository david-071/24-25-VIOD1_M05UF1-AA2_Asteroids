using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    public float horizontal;
    public float vertical;
    public float speed;
    void Start()
    {
        horizontal = Random.Range(-1f, 1f);
        vertical = Random.Range(-1f, 1f);
        speed = Random.Range(-1f, 1f);
        rb = GetComponent<Rigidbody2D>();
        //Transform.eulerAngles = transform.eulerAngles

    }
}
