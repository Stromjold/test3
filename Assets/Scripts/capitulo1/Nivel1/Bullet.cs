using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;
    public float speed = 15f; // Velocidad de la bala

    // La torreta llama a esta función para decirle a la bala a quién perseguir
    public void Seek(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        // Si el enemigo muere antes de que la bala llegue, la bala se destruye
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        // Calcula la dirección matemática hacia el mutante
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        // Si la distancia es menor a lo que se mueve en este frame, impactó
        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        // Mueve la bala hacia el objetivo
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }

    void HitTarget()
    {
        Destroy(target.gameObject); // Destruye al mutante enemigo
        Destroy(gameObject); // Destruye la bala al chocar
    }
}