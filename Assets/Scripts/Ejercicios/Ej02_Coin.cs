using UnityEngine;

/// <summary>
/// EJERCICIO 2 —  Sistema de Monedas Coleccionables
/// Crea una clase Coin con un valor entero. Cuando el jugador toque la moneda,
/// esta muestra su valor en consola y desaparece del juego.
/// Setup en escena: Sprite (Circle) + Collider2D con "Is Trigger" activado.
/// El jugador necesita un Collider2D + Rigidbody2D (Gravity Scale = 0)
/// y el Tag "Player".
/// </summary>
public class Ej02_Coin : MonoBehaviour
{
    // TODO 1: Declara el ATRIBUTO valor (int). Prueba dándole distintos
    //         valores a cada moneda desde el Inspector: misma CLASE,
    //         OBJETOS con estado propio.


    // TODO 2: Detecta el contacto con el jugador.
    //  Pista: usa el método de Unity OnTriggerEnter2D(Collider2D other)
    //           y pregunta si other.CompareTag("Player").

    // TODO 3: Al recogerla, muestra el valor en consola y destruye la moneda.
    //  Pista: Debug.Log(...) y Destroy(gameObject);

}
