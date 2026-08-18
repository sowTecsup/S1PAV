using UnityEngine;

/// <summary>
/// EJERCICIO 4 — 🎮 Bala que daña enemigos
/// Crea una clase Bullet que se mueva hacia adelante constantemente.
/// Cuando colisione con un enemigo, le aplica daño y se destruye a sí misma.
/// Setup en escena: Sprite (Circle pequeño) + Collider2D "Is Trigger"
/// + Rigidbody2D (Gravity Scale = 0). Necesita un Ej03_Enemy en la escena.
/// </summary>
public class Ej04_Bullet : MonoBehaviour
{
    // TODO 1: Declara los ATRIBUTOS velocidad (float) y danio (int).


    void Update()
    {
        // TODO 2: Mueve la bala hacia adelante constantemente.
        // 💡 Pista: transform.position += transform.right * velocidad * Time.deltaTime;
    }

    // TODO 3: Cuando toque un objeto con Tag "Enemy":
    //         a) pide su componente Ej03_Enemy con GetComponent
    //         b) llámale a RecibirDanio(danio)   <-- ¡un OBJETO hablando con otro!
    //         c) destruye la bala.
    // 💡 Pista:
    //    private void OnTriggerEnter2D(Collider2D other)
    //    {
    //        if (other.CompareTag("Enemy")) { ... }
    //    }

}
