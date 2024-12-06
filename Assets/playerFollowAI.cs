using UnityEngine;

public class playerFollowAI : MonoBehaviour
{
    [SerializeField] private Transform playerTras;
    UnityEngine.AI.NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = playerTras.position;
    }
}
