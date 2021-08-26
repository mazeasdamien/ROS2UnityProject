//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class RenameRobotStateInWarehouseRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/RenameRobotStateInWarehouse";
        public override string RosMessageName => k_RosMessageName;

        public string old_name;
        public string new_name;
        public string robot;

        public RenameRobotStateInWarehouseRequest()
        {
            this.old_name = "";
            this.new_name = "";
            this.robot = "";
        }

        public RenameRobotStateInWarehouseRequest(string old_name, string new_name, string robot)
        {
            this.old_name = old_name;
            this.new_name = new_name;
            this.robot = robot;
        }

        public static RenameRobotStateInWarehouseRequest Deserialize(MessageDeserializer deserializer) => new RenameRobotStateInWarehouseRequest(deserializer);

        private RenameRobotStateInWarehouseRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.old_name);
            deserializer.Read(out this.new_name);
            deserializer.Read(out this.robot);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.old_name);
            serializer.Write(this.new_name);
            serializer.Write(this.robot);
        }

        public override string ToString()
        {
            return "RenameRobotStateInWarehouseRequest: " +
            "\nold_name: " + old_name.ToString() +
            "\nnew_name: " + new_name.ToString() +
            "\nrobot: " + robot.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
