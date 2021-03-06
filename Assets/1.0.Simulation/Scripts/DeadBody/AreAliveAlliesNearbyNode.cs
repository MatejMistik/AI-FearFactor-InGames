using UnityEngine;
using SensorToolkit;

public class AreAliveAlliesNearby : Node
{
    private Sensor sensor;
    private int alliesAliveCounter;

    public AreAliveAlliesNearby(Sensor sensor)
    {
        this.sensor = sensor;
    }

    public override NodeState Evaluate()
    {
        foreach(GameObject detectedObject in sensor.DetectedObjects)
        {
            if (detectedObject.name == "Enemy" && detectedObject.CompareTag("Enemy"))
            {
                alliesAliveCounter++;   
            }
        }
        if(alliesAliveCounter > 0)
        { 
            alliesAliveCounter = 0;
            return NodeState.SUCCESS;
        }
        return NodeState.FAILURE;
    }
}
