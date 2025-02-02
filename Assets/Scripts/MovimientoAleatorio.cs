using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public float forceMagnitude = 4f;
    public float rotationMagnitude = 5f;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.AddForce(randomDirection * forceMagnitude, ForceMode2D.Impulse);

        float randomTorque = Random.Range(-rotationMagnitude, rotationMagnitude);
        rb.AddTorque(randomTorque, ForceMode2D.Impulse);
    }
}
