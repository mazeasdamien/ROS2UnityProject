//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class GetPositionIKRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/GetPositionIK";
        public override string RosMessageName => k_RosMessageName;

        //  A service call to carry out an inverse kinematics computation
        //  The inverse kinematics request
        public PositionIKRequestMsg ik_request;

        public GetPositionIKRequest()
        {
            this.ik_request = new PositionIKRequestMsg();
        }

        public GetPositionIKRequest(PositionIKRequestMsg ik_request)
        {
            this.ik_request = ik_request;
        }

        public static GetPositionIKRequest Deserialize(MessageDeserializer deserializer) => new GetPositionIKRequest(deserializer);

        private GetPositionIKRequest(MessageDeserializer deserializer)
        {
            this.ik_request = PositionIKRequestMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.ik_request);
        }

        public override string ToString()
        {
            return "GetPositionIKRequest: " +
            "\nik_request: " + ik_request.ToString();
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
