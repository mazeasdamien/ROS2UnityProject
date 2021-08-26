using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;
using System;
using System.Collections.Generic;

public class JointSub : MonoBehaviour
{
    public double[] pos;
    public ArticulationBody[] joints;
    public string topicName;
    private bool isMessageReceived;
    public List<float> poss = new List<float>();

    void Start()
    {
        ROSConnection.instance.Subscribe<JointStateMsg>(topicName, UpdateJoint);
    }

    void UpdateJoint(JointStateMsg js)
    {
        pos = js.position;

        isMessageReceived = true;
        if (isMessageReceived)
            ProcessMessage();
    }

    private void ProcessMessage()
    {
        joints[0].GetJointPositions(poss);
        for (int i = 0; i < pos.Length; i++)
        {
            //var lst = new List<float>();
            //lst.Add((float)(pos[i] * (180 / Math.PI)));
            //joints[i].SetDriveTargets(lst);

        }
        isMessageReceived = false;
    }
}
