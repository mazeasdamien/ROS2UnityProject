//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class DeleteRobotStateFromWarehouseResponse : Message
    {
        public const string k_RosMessageName = "moveit_msgs/DeleteRobotStateFromWarehouse";
        public override string RosMessageName => k_RosMessageName;


        public DeleteRobotStateFromWarehouseResponse()
        {
        }
        public static DeleteRobotStateFromWarehouseResponse Deserialize(MessageDeserializer deserializer) => new DeleteRobotStateFromWarehouseResponse(deserializer);

        private DeleteRobotStateFromWarehouseResponse(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "DeleteRobotStateFromWarehouseResponse: ";
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
