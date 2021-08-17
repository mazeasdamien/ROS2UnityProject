//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class AllowedCollisionMatrixMsg : Message
    {
        public const string k_RosMessageName = "moveit_msgs/AllowedCollisionMatrix";
        public override string RosMessageName => k_RosMessageName;

        //  The list of entry names in the matrix
        public string[] entry_names;
        //  The individual entries in the allowed collision matrix
        //  square, symmetric, with same order as entry_names
        public AllowedCollisionEntryMsg[] entry_values;
        //  In addition to the collision matrix itself, we also have 
        //  the default entry value for each entry name.
        //  If the allowed collision flag is queried for a pair of names (n1, n2)
        //  that is not found in the collision matrix itself, the value of
        //  the collision flag is considered to be that of the entry (n1 or n2)
        //  specified in the list below. If both n1 and n2 are found in the list 
        //  of defaults, the result is computed with an AND operation
        public string[] default_entry_names;
        public bool[] default_entry_values;

        public AllowedCollisionMatrixMsg()
        {
            this.entry_names = new string[0];
            this.entry_values = new AllowedCollisionEntryMsg[0];
            this.default_entry_names = new string[0];
            this.default_entry_values = new bool[0];
        }

        public AllowedCollisionMatrixMsg(string[] entry_names, AllowedCollisionEntryMsg[] entry_values, string[] default_entry_names, bool[] default_entry_values)
        {
            this.entry_names = entry_names;
            this.entry_values = entry_values;
            this.default_entry_names = default_entry_names;
            this.default_entry_values = default_entry_values;
        }

        public static AllowedCollisionMatrixMsg Deserialize(MessageDeserializer deserializer) => new AllowedCollisionMatrixMsg(deserializer);

        private AllowedCollisionMatrixMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.entry_names, deserializer.ReadLength());
            deserializer.Read(out this.entry_values, AllowedCollisionEntryMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.default_entry_names, deserializer.ReadLength());
            deserializer.Read(out this.default_entry_values, sizeof(bool), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.entry_names);
            serializer.Write(this.entry_names);
            serializer.WriteLength(this.entry_values);
            serializer.Write(this.entry_values);
            serializer.WriteLength(this.default_entry_names);
            serializer.Write(this.default_entry_names);
            serializer.WriteLength(this.default_entry_values);
            serializer.Write(this.default_entry_values);
        }

        public override string ToString()
        {
            return "AllowedCollisionMatrixMsg: " +
            "\nentry_names: " + System.String.Join(", ", entry_names.ToList()) +
            "\nentry_values: " + System.String.Join(", ", entry_values.ToList()) +
            "\ndefault_entry_names: " + System.String.Join(", ", default_entry_names.ToList()) +
            "\ndefault_entry_values: " + System.String.Join(", ", default_entry_values.ToList());
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
