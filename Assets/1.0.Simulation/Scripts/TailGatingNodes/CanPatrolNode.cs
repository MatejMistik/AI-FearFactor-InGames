using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SensorToolkit;
using UnityEngine.AI;

public class CanPatrolNode : Node
{
    AiTreeConstructor ai;
    Sensor sensor;
    NavMeshAgent agent;

    public CanPatrolNode(AiTreeConstructor ai, Sensor sensor, NavMeshAgent agent)
    {
        this.ai = ai;
        this.sensor = sensor;
        this.agent = agent;
    }

    public override NodeState Evaluate()
    {
        if (sensor.GetNearestByName("FirstPersonPlayer"))
        {
            return NodeState.FAILURE;
        }
        return NodeState.SUCCESS;
    }
}
