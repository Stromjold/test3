using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    
    [Header("Resistencia")]
    public int health = 5; // La cantidad de balas que resiste el mutante

    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {
        if (Waypoints.points == null || Waypoints.points.Length == 0) return;
        target = Waypoints.points[0];
    }

    void Update()
    {
        if (target == null) return;

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return; 
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    // Nueva función: El enemigo recibe daño y calcula si debe morir
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Aquí más adelante puedes poner una animación o efecto de sangre
        Destroy(gameObject);
    }
}