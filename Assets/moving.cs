using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class moving : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento de la plataforma
    private bool movingRight = true; // Indica la direcci�n del movimiento

    // Update is called once per frame
    void Update()
    {
        // Cambiar la direcci�n del movimiento cuando se alcanza un l�mite
        if (transform.position.x >= 5f)
        {
            movingRight = false;
        }
        else if (transform.position.x <= -5f)
        {
            movingRight = true;
        }

        // Mover la plataforma horizontalmente
        float horizontalSpeed = movingRight ? speed : -speed;
        transform.Translate(new Vector2(horizontalSpeed, 0f) * Time.deltaTime);
    }
}



