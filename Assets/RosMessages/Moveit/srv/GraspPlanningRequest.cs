//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Moveit
{
    [Serializable]
    public class GraspPlanningRequest : Message
    {
        public const string k_RosMessageName = "moveit_msgs-master/GraspPlanning";
        public override string RosMessageName => k_RosMessageName;

        //  Requests that grasp planning be performed for the target object
        //  returns a list of candidate grasps to be tested and executed
        //  the planning group used
        public string group_name;
        //  the object to be grasped
        public CollisionObjectMsg target;
        //  the names of the relevant support surfaces (e.g. tables) in the collision map
        //  can be left empty if no names are available
        public string[] support_surfaces;
        //  an optional list of grasps to be evaluated by the planner
        public GraspMsg[] candidate_grasps;
        //  an optional list of obstacles that we have semantic information about
        //  and that can be moved in the course of grasping
        public CollisionObjectMsg[] movable_obstacles;

        public GraspPlanningRequest()
        {
            this.group_name = "";
            this.target = new CollisionObjectMsg();
            this.support_surfaces = new string[0];
            this.candidate_grasps = new GraspMsg[0];
            this.movable_obstacles = new CollisionObjectMsg[0];
        }

        public GraspPlanningRequest(string group_name, CollisionObjectMsg target, string[] support_surfaces, GraspMsg[] candidate_grasps, CollisionObjectMsg[] movable_obstacles)
        {
            this.group_name = group_name;
            this.target = target;
            this.support_surfaces = support_surfaces;
            this.candidate_grasps = candidate_grasps;
            this.movable_obstacles = movable_obstacles;
        }

        public static GraspPlanningRequest Deserialize(MessageDeserializer deserializer) => new GraspPlanningRequest(deserializer);

        private GraspPlanningRequest(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.group_name);
            this.target = CollisionObjectMsg.Deserialize(deserializer);
            deserializer.Read(out this.support_surfaces, deserializer.ReadLength());
            deserializer.Read(out this.candidate_grasps, GraspMsg.Deserialize, deserializer.ReadLength());
            deserializer.Read(out this.movable_obstacles, CollisionObjectMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.group_name);
            serializer.Write(this.target);
            serializer.WriteLength(this.support_surfaces);
            serializer.Write(this.support_surfaces);
            serializer.WriteLength(this.candidate_grasps);
            serializer.Write(this.candidate_grasps);
            serializer.WriteLength(this.movable_obstacles);
            serializer.Write(this.movable_obstacles);
        }

        public override string ToString()
        {
            return "GraspPlanningRequest: " +
            "\ngroup_name: " + group_name.ToString() +
            "\ntarget: " + target.ToString() +
            "\nsupport_surfaces: " + System.String.Join(", ", support_surfaces.ToList()) +
            "\ncandidate_grasps: " + System.String.Join(", ", candidate_grasps.ToList()) +
            "\nmovable_obstacles: " + System.String.Join(", ", movable_obstacles.ToList());
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
