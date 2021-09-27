using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalDetect : MonoBehaviour
{
    [HideInInspector]
    public PushAgentBase agent;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("goal"))
        {
            agent.ScoredAGoal();
        }
    }
}
