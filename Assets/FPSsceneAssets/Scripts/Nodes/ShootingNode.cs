using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShootingNode : Node
{
    public NavMeshAgent agent;
    private AnimatorAI ai;
    private Transform playerTransform;
    public RayCastWeapon weapon;

    public ShootingNode(NavMeshAgent agent, AnimatorAI ai, Transform playerTransform, RayCastWeapon weapon)
    {
        this.agent = agent;
        this.ai = ai;
        this.playerTransform = playerTransform;
        this.weapon = weapon;
    }

    public override NodeState Evaluate()
    {
        agent.isStopped = true;
        ai.DebugMessage("Shooting");
        agent.transform.LookAt(playerTransform);
        //Debug.Log(weapon);
        weapon.PrepareToShoot();
        return NodeState.RUNNING;
    }

}
