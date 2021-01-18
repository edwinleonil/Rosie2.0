/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;
using System.Collections.Generic;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PoseArrayFixed : Message
    {
        public const string RosMessageName = "geometry_msgs/PoseArray";

        //  An array of poses with a header for global reference.
        public Header header { get; set; }
        public List<Pose> poses { get; set; }

        public PoseArrayFixed()
        {
            this.header = new Header();
            this.poses = new List<Pose>();
        }

        public PoseArrayFixed(Header header, List<Pose> poses)
        {
            this.header = header;
            this.poses = poses;
        }
    }
}
