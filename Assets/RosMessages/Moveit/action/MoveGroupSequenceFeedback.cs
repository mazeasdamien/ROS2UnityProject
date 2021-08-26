//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class MoveGroupSequenceFeedback : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/MoveGroupSequence";
        public override string RosMessageName => k_RosMessageName;

        //  The internal state that the move group action currently is in
        public string state;

        public MoveGroupSequenceFeedback()
        {
            this.state = "";
        }

        public MoveGroupSequenceFeedback(string state)
        {
            this.state = state;
        }

        public static MoveGroupSequenceFeedback Deserialize(MessageDeserializer deserializer) => new MoveGroupSequenceFeedback(deserializer);

        private MoveGroupSequenceFeedback(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.state);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.state);
        }

        public override string ToString()
        {
            return "MoveGroupSequenceFeedback: " +
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
