//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class ApplyPlanningSceneRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/ApplyPlanningScene";
        public override string RosMessageName => k_RosMessageName;

        public PlanningSceneMsg scene;

        public ApplyPlanningSceneRequest()
        {
            this.scene = new PlanningSceneMsg();
        }

        public ApplyPlanningSceneRequest(PlanningSceneMsg scene)
        {
            this.scene = scene;
        }

        public static ApplyPlanningSceneRequest Deserialize(MessageDeserializer deserializer) => new ApplyPlanningSceneRequest(deserializer);

        private ApplyPlanningSceneRequest(MessageDeserializer deserializer)
        {
            this.scene = PlanningSceneMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.scene);
        }

        public override string ToString()
        {
            return "ApplyPlanningSceneRequest: " +
            "\nscene: " + scene.ToString();
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
