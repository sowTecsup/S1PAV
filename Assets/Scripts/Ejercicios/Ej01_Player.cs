using UnityEngine;

/// <summary>
/// EJERCICIO 1 — Sistema de Jugador Básico
/// Crea una clase Player con atributos básicos (nombre, vida y velocidad)
/// y métodos para moverse en el eje X y recibir daño.
/// Setup en escena: un Sprite (Square) con este script.
/// </summary>
public class Ej01_Player : MonoBehaviour
{
    // TODO 1: Declara los ATRIBUTOS del jugador:
    //         - nombre (string)
    //         - vida (int)
    //         - velocidad (float)
    // Pista: hazlos public para verlos en el Inspector.


    void Update()
    {
        // TODO 2: Lee el input horizontal y llama al método Mover.
        // Pista: float direccion = Input.GetAxis("Horizontal");
        //           (o Input.GetKey(KeyCode.A) / KeyCode.D si prefieren)

    }

    // TODO 3: Crea el MÉTODO Mover(float direccion) que desplace al jugador
    //         en el eje X usando velocidad y Time.deltaTime.
    //  Pista: transform.position += Vector3.right * direccion * velocidad * Time.deltaTime;


    // TODO 4: Crea el MÉTODO RecibirDanio(int danio) que reste vida
    //         y muestre en consola la vida restante.
    //  Pista: ¿Qué debería pasar si la vida llega a 0?

}
