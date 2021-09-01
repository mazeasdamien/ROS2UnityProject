using RosMessageTypes.FanucgripperMoveitConfig;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using Unity.Robotics.ROSTCPConnector.ROSGeometry;
using Unity.Robotics.UrdfImporter;
using RosMessageTypes.Geometry;
using UnityEngine.UI;

public class SourceDestinationPublisher : MonoBehaviour
{
    // ROS Connector
    private ROSConnection ros;
    public Text joints_info;

    // Variables required for ROS communication
    public string topicName = "SourceDestination_input";

    public GameObject fanuc;
    public GameObject target;
    public GameObject targetPlacement;

    private int numRobotJoints = 6;
    private readonly Quaternion pickOrientation = Quaternion.Euler(90, 90, 0);

    // Robot Joints
    private UrdfJointRevolute[] revoluteJoints;

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        // Get ROS connection static instance
        ros = ROSConnection.instance;
        ros.RegisterPublisher<FanucMoveitJointsMsg>(topicName);

        revoluteJoints = new UrdfJointRevolute[numRobotJoints];
        string link_1 = "base_link/link_1";
        revoluteJoints[0] = fanuc.transform.Find(link_1).GetComponent<UrdfJointRevolute>();

        string link_2 = link_1 + "/link_2";
        revoluteJoints[1] = fanuc.transform.Find(link_2).GetComponent<UrdfJointRevolute>();

        string link_3 = link_2 + "/link_3";
        revoluteJoints[2] = fanuc.transform.Find(link_3).GetComponent<UrdfJointRevolute>();

        string link_4 = link_3 + "/link_4";
        revoluteJoints[3] = fanuc.transform.Find(link_4).GetComponent<UrdfJointRevolute>();

        string link_5 = link_4 + "/link_5";
        revoluteJoints[4] = fanuc.transform.Find(link_5).GetComponent<UrdfJointRevolute>();

        string end_effector = link_5 + "/end_effector";
        revoluteJoints[5] = fanuc.transform.Find(end_effector).GetComponent<UrdfJointRevolute>();
    }

    private void Update()
    {
        joints_info.text = "J0 = " + Mathf.Round(revoluteJoints[0].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nJ1 = " + Mathf.Round(revoluteJoints[1].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nJ2 = " + Mathf.Round(revoluteJoints[2].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nJ3 = " + Mathf.Round(revoluteJoints[3].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nJ4 = " + Mathf.Round(revoluteJoints[4].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nJ5 = " + Mathf.Round(revoluteJoints[5].GetPosition() * Mathf.Rad2Deg) + "°" +
                           "\nGripper = Open";
    }

    public void Publish()
    {
        FanucMoveitJointsMsg sourceDestinationMessage = new FanucMoveitJointsMsg();

        sourceDestinationMessage.joint_00 = revoluteJoints[0].GetPosition() * Mathf.Rad2Deg;
        sourceDestinationMessage.joint_01 = revoluteJoints[1].GetPosition() * Mathf.Rad2Deg;
        sourceDestinationMessage.joint_02 = revoluteJoints[2].GetPosition() * Mathf.Rad2Deg;
        sourceDestinationMessage.joint_03 = revoluteJoints[3].GetPosition() * Mathf.Rad2Deg;
        sourceDestinationMessage.joint_04 = revoluteJoints[4].GetPosition() * Mathf.Rad2Deg;
        sourceDestinationMessage.joint_05 = revoluteJoints[5].GetPosition() * Mathf.Rad2Deg;

        // Pick Pose
        sourceDestinationMessage.pick_pose = new PoseMsg
        {
            position = target.transform.position.To<FLU>(),
            orientation = Quaternion.Euler(90, target.transform.eulerAngles.y, 0).To<FLU>()
        };

        // Place Pose
        sourceDestinationMessage.place_pose = new PoseMsg
        {
            position = targetPlacement.transform.position.To<FLU>(),
            orientation = pickOrientation.To<FLU>()
        };

        // Finally send the message to server_endpoint.py running in ROS
        ros.Send(topicName, sourceDestinationMessage);
    }
}
