//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class UpdatePointcloudOctomapRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/UpdatePointcloudOctomap";
        public override string RosMessageName => k_RosMessageName;

        public Sensor.PointCloud2Msg cloud;

        public UpdatePointcloudOctomapRequest()
        {
            this.cloud = new Sensor.PointCloud2Msg();
        }

        public UpdatePointcloudOctomapRequest(Sensor.PointCloud2Msg cloud)
        {
            this.cloud = cloud;
        }

        public static UpdatePointcloudOctomapRequest Deserialize(MessageDeserializer deserializer) => new UpdatePointcloudOctomapRequest(deserializer);

        private UpdatePointcloudOctomapRequest(MessageDeserializer deserializer)
        {
            this.cloud = Sensor.PointCloud2Msg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.cloud);
        }

        public override string ToString()
        {
            return "UpdatePointcloudOctomapRequest: " +
            "\ncloud: " + cloud.ToString();
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
