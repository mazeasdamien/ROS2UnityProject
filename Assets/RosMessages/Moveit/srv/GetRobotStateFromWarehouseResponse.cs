//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class GetRobotStateFromWarehouseResponse : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/GetRobotStateFromWarehouse";
        public override string RosMessageName => k_RosMessageName;

        public RobotStateMsg state;

        public GetRobotStateFromWarehouseResponse()
        {
            this.state = new RobotStateMsg();
        }

        public GetRobotStateFromWarehouseResponse(RobotStateMsg state)
        {
            this.state = state;
        }

        public static GetRobotStateFromWarehouseResponse Deserialize(MessageDeserializer deserializer) => new GetRobotStateFromWarehouseResponse(deserializer);

        private GetRobotStateFromWarehouseResponse(MessageDeserializer deserializer)
        {
            this.state = RobotStateMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.state);
        }

        public override string ToString()
        {
            return "GetRobotStateFromWarehouseResponse: " +
            "\nstate: " + state.ToString();
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
