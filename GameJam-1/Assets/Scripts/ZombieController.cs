
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    public Transform player;  
    public float speed = 2.0f;
    NavMeshAgent agent;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       
        if (player != null)
        {
            agent.SetDestination(player.position);
        }
    }
}
