using UnityEngine;

/// <summary>
/// EJERCICIO 3 — 🎮 Sistema de Enemigo con Vida
/// Crea una clase Enemy con un atributo de vida, un método para recibir daño
/// y otro para morir cuando su vida llegue a cero (eliminando el objeto).
/// Setup en escena: Sprite (Square rojo) + Collider2D con "Is Trigger" activado
/// y el Tag "Enemy" (créenlo en Add Tag).
/// </summary>
public class Ej03_Enemy : MonoBehaviour
{
    // TODO 1: Declara el ATRIBUTO vida (int).


    // TODO 2: Crea el MÉTODO público RecibirDanio(int danio) que reste vida.
    //         Si la vida llega a 0 o menos, llama a Morir().
    //  Pista: este método lo llamará la bala del Ejercicio 4,
    //           por eso DEBE ser public. ¿Quién puede llamar a un método private?


    // TODO 3: Crea el MÉTODO Morir() que avise en consola y elimine
    //         el objeto del juego.
    //  Pista: Destroy(gameObject);

}
