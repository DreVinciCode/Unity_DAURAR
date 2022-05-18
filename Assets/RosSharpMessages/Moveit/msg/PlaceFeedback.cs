/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class PlaceFeedback : Message
    {
        public const string RosMessageName = "moveit_msgs/PlaceFeedback";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        //  The internal state that the place action currently is in
        public string state { get; set; }

        public PlaceFeedback()
        {
            this.state = "";
        }

        public PlaceFeedback(string state)
        {
            this.state = state;
        }
    }
}
