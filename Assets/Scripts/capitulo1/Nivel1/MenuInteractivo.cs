using UnityEngine;

public class MenuInteractivo : MonoBehaviour
{
    [Header("Interfaz del Nodo")]
    public GameObject menuCanvas; // La ranura para tu menú de Canva

    void Start()
    {
        // Regla de inicio: El menú siempre debe estar oculto al empezar la partida
        if (menuCanvas != null)
        {
            menuCanvas.SetActive(false);
        }
    }

    // Esta función nativa de Unity se activa automáticamente al hacer clic sobre el BoxCollider2D
    void OnMouseDown()
    {
        if (menuCanvas != null)
        {
            // Alternador (Toggle): Si está apagado lo prende, y si está prendido lo apaga
            bool estadoActual = menuCanvas.activeSelf;
            menuCanvas.SetActive(!estadoActual);
        }
    }
}