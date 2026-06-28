using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // La ranura para colocar el molde (Prefab) de tu enemigo
    public GameObject enemigoPrefab; 
    
    // El tiempo en segundos que espera entre cada creación
    public float tiempoEntreEnemigos = 1.5f; 

    void Start()
    {
        // Iniciamos la rutina automática en cuanto empieza el juego
        StartCoroutine(GenerarOleada());
    }

    // Una Corrutina nos permite pausar la ejecución (esperar segundos) sin congelar el juego
    IEnumerator GenerarOleada()
    {
        while (true) // Bucle infinito para probar el flujo constante
        {
            // Creamos una copia del enemigo exactamente en la posición de este Spawner
            Instantiate(enemigoPrefab, transform.position, Quaternion.identity);
            
            // Le decimos al motor que espere X segundos antes de repetir el bucle
            yield return new WaitForSeconds(tiempoEntreEnemigos);
        }
    }
}