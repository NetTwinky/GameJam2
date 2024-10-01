using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent agent;
    private int currentTarget = 0;
    public Transform[] targets; // creates array that you manipulate within Unity!

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = targets[currentTarget].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            // Move to the next target
            currentTarget = (currentTarget + 1) % targets.Length;
            agent.destination = targets[currentTargetIndex].position;
        }
    }
}
