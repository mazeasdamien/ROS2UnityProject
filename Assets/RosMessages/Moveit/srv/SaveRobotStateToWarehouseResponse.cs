//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class SaveRobotStateToWarehouseResponse : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/SaveRobotStateToWarehouse";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public SaveRobotStateToWarehouseResponse()
        {
            this.success = false;
        }

        public SaveRobotStateToWarehouseResponse(bool success)
        {
            this.success = success;
        }

        public static SaveRobotStateToWarehouseResponse Deserialize(MessageDeserializer deserializer) => new SaveRobotStateToWarehouseResponse(deserializer);

        private SaveRobotStateToWarehouseResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "SaveRobotStateToWarehouseResponse: " +
            "\nsuccess: " + success.ToString();
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
