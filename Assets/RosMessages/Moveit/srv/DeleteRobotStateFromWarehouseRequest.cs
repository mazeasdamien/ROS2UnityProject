//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class DeleteRobotStateFromWarehouseRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/DeleteRobotStateFromWarehouse";
        public override string RosMessageName => k_RosMessageName;

        public string name;
        public string robot;

        public DeleteRobotStateFromWarehouseRequest()
        {
            this.name = "";
            this.robot = "";
        }

        public DeleteRobotStateFromWarehouseRequest(string name, string robot)
        {
            this.name = name;
            this.robot = robot;
        }

        public static DeleteRobotStateFromWarehouseRequest Deserialize(MessageDeserializer deserializer) => new DeleteRobotStateFromWarehouseRequest(deserializer);

        private DeleteRobotStateFromWarehouseRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.name);
            deserializer.Read(out this.robot);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.name);
            serializer.Write(this.robot);
        }

        public override string ToString()
        {
            return "DeleteRobotStateFromWarehouseRequest: " +
            "\nname: " + name.ToString() +
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
