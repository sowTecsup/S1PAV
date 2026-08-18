using UnityEngine;

/// <summary>
/// La clase es el MOLDE  ; el objeto es la INSTANCIA  con valores propios.
/// Cómo usarla: crear un GameObject vacío en la escena, arrastrar este script
/// y darle Play mirando la consola.
/// </summary>
public class Demo_ClasesYObjetos : MonoBehaviour
{
    void Start()
    {
        // Una sola clase (el molde)...
        Pokemon charmander = new Pokemon();
        charmander.nombre = "Charmander";
        charmander.vida = 39;
        charmander.tipo = "Fuego";

        Pokemon squirtle = new Pokemon();
        squirtle.nombre = "Squirtle";
        squirtle.vida = 44;
        squirtle.tipo = "Agua";

        Pokemon pikachu = new Pokemon();
        pikachu.nombre = "Pikachu";
        pikachu.vida = 35;
        pikachu.tipo = "Electrico";

        // ...tres OBJETOS distintos, cada uno con sus propios valores.
        charmander.Presentarse();
        squirtle.Presentarse();
        pikachu.Presentarse();

        // Cada objeto guarda su PROPIO estado: dañar a uno no afecta a los demás.
        pikachu.RecibirDanio(10);
        charmander.RecibirDanio(50);
        squirtle.Presentarse(); // Squirtle sigue intacto

        // ¿Se dieron cuenta de que inicializar cada objeto toma 3 líneas?
        // La próxima sesión veremos CONSTRUCTORES para resolver justo eso.
    }
}

/// <summary>
/// Una clase agrupa ATRIBUTOS (datos) + MÉTODOS (comportamiento).
/// Esta NO hereda de MonoBehaviour: es una clase "pura" de C#,
/// por eso podemos crearla con new. Los scripts-componente (MonoBehaviour)
/// no se crean con new: Unity los instancia al añadirlos a un GameObject.
/// </summary>
public class Pokemon
{
    // ---- Atributos ----
    public string nombre;
    public int vida;
    public string tipo;

    // ---- Métodos ----
    public void Presentarse()
    {
        Debug.Log($"Soy {nombre}, tipo {tipo}, con {vida} de vida.");
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;

        if (vida <= 0)
        {
            vida = 0;
            Debug.Log($"{nombre} se ha debilitado :(");
        }
        else
        {
            Debug.Log($"{nombre} recibió {danio} de daño. Vida restante: {vida}");
        }
    }
}
