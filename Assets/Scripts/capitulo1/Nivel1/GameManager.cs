using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Esta línea crea un acceso global para que cualquier script pueda hablar con el árbitro
    public static GameManager instance; 

    [Header("Reglas del Nivel")]
    public int enemigosEliminados = 0;
    public int metaEnemigos = 150; // Tu límite de victoria

    void Awake()
    {
        // Al despertar, el script se designa a sí mismo como el árbitro oficial
        instance = this; 
    }

    // Esta función será llamada cada vez que un monstruo muera
    public void RegistrarMuerte()
    {
        enemigosEliminados++; // Sumamos 1 al contador
        Debug.Log("Mutantes eliminados: " + enemigosEliminados);

        // Evaluamos si ya llegamos a la meta
        if (enemigosEliminados >= metaEnemigos)
        {
            DeclararVictoria();
        }
    }

    void DeclararVictoria()
    {
        Debug.Log("¡VICTORIA! El puerto está limpio.");
        // Más adelante, aquí pondremos el código para pausar el juego o mostrar el menú de ganar
    }
}