using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform baseTransform;

    void Start()
    {
        // Vind de NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();

        // Zoek de Base met de tag "attackbase"
        GameObject baseObject = GameObject.FindGameObjectWithTag("attackbase");
        if (baseObject != null)
        {
            baseTransform = baseObject.transform;
        }
        else
        {
            Debug.LogWarning("Base not found!");
        }
    }

    void Update()
    {
        // Beweeg naar de positie van de Base als deze is gevonden
        if (baseTransform != null)
        {
            agent.SetDestination(baseTransform.position);
        }
    }
}
