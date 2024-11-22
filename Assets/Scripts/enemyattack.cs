using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damageAmount = 10f;       // Schade per aanval
    public float attackCooldown = 2f;      // Tijd tussen aanvallen
    private float lastAttackTime;          // Tijd sinds laatste aanval

    private Health baseHealth;             // Referentie Health script base

    // Deze methode wordt aangeroepen wanneer er een collision gebeurt
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("attackbase")) 
        {
            baseHealth = collision.gameObject.GetComponent<Health>();
        }
    }

    // Deze methode wordt aangeroepen wanneer de collision eindigt
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("attackbase"))
        {
            baseHealth = null; 
            // Verwijdert de referentie wanneer de vijand de base verlaat
        }
    }

    // Deze methode wordt elke frame aangeroepen om de aanval te verwerken
    void Update()
    {
        if (baseHealth != null && Time.time >= lastAttackTime + attackCooldown)
        {
            baseHealth.TakeDamage(damageAmount); // Schade doen aan de base
            lastAttackTime = Time.time;          // Tijd van laatste aanval bijwerken
            Debug.Log(this.name + " attacked the Base!");
        }
    }
}
