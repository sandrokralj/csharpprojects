using System.Drawing;
using City_Traffic_Simulation_Application;
// <copyright file="WaypointFactory.cs">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;

namespace City_Traffic_Simulation_Application
{
    /// <summary>A factory for City_Traffic_Simulation_Application.Waypoint instances</summary>
    public static partial class WaypointFactory
    {
        /// <summary>A factory for City_Traffic_Simulation_Application.Waypoint instances</summary>
        [PexFactoryMethod(typeof(Waypoint))]
        public static Waypoint Create(
            Point p_point,
            Waypoint w_waypoint1,
            double x_d,
            Waypoint nextWaypoint_waypoint2,
            Waypoint waypointStraight_waypoint3,
            Waypoint waypointLeft_waypoint4,
            Waypoint waypointRight_waypoint5,
            string End_s,
            int waitingcars_i,
            double y_d1,
            bool value_b
        )
        {
            Waypoint waypoint = new Waypoint(p_point, w_waypoint1);
            waypoint.x = x_d;
            waypoint.nextWaypoint = nextWaypoint_waypoint2;
            waypoint.waypointStraight = waypointStraight_waypoint3;
            waypoint.waypointLeft = waypointLeft_waypoint4;
            waypoint.waypointRight = waypointRight_waypoint5;
            waypoint.End = End_s;
            waypoint.waitingcars = waitingcars_i;
            waypoint.y = y_d1;
            waypoint.RedLight = value_b;
            return waypoint;

            // TODO: Edit factory method of Waypoint
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
