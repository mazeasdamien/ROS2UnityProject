//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class ChangeControlDimensionsResponse : Message
    {
        public const string k_RosMessageName = "moveit_msgs/ChangeControlDimensions";
        public override string RosMessageName => k_RosMessageName;

        public bool success;

        public ChangeControlDimensionsResponse()
        {
            this.success = false;
        }

        public ChangeControlDimensionsResponse(bool success)
        {
            this.success = success;
        }

        public static ChangeControlDimensionsResponse Deserialize(MessageDeserializer deserializer) => new ChangeControlDimensionsResponse(deserializer);

        private ChangeControlDimensionsResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.success);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.success);
        }

        public override string ToString()
        {
            return "ChangeControlDimensionsResponse: " +
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
