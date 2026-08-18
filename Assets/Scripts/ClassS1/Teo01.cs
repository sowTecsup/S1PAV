using UnityEngine;

public class Teo01 : MonoBehaviour
{

    void Start()
    {
        PokemonA charmander = new PokemonA();
        charmander.PokeName = "Charmander";
        charmander.Atk = 6;
        charmander.Vit = 7;
        charmander.Type = PokemonType.Fuego;

        PokemonA Squirtle = new PokemonA();
        Squirtle.PokeName = "Squirtle";
        Squirtle.Atk = 14;
        Squirtle.Vit = 8;
        Squirtle.Type = PokemonType.Agua;

        PokemonA Bulbasaur = new PokemonA();
        Bulbasaur.PokeName = "Bulbasaur";
        Bulbasaur.Atk = 14;
        Bulbasaur.Vit = 8;
        Bulbasaur.Type = PokemonType.Planta;

        charmander.Introduction();
        Squirtle.Introduction();
        Bulbasaur.Introduction();
    }
}

public enum PokemonType
{
    Planta,//->0
    Fuego,//-> 1
    Agua//->2
}
public class PokemonA
{
    //-> Atributos
    public string PokeName;
    public int Atk;
    public int Vit;
    public PokemonType Type;

    //-> Metodos o comportamiento
    public void Introduction()
    {
        Debug.Log("Soy" + PokeName
            + "\n Mis puntos de ataque son: " + Atk
            + "\n Mis puntos de defensa son: " + Vit
            + "\n Soy de tipo: " + Type.ToString());
    }

}
