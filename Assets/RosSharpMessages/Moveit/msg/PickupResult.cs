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
    public class PickupResult : Message
    {
        public const string RosMessageName = "moveit_msgs/PickupResult";

        //  ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
        //  The overall result of the pickup attempt
        public MoveItErrorCodes error_code { get; set; }
        //  The full starting state of the robot at the start of the trajectory
        public RobotState trajectory_start { get; set; }
        //  The trajectory that moved group produced for execution
        public RobotTrajectory[] trajectory_stages { get; set; }
        public string[] trajectory_descriptions { get; set; }
        //  The performed grasp, if attempt was successful
        public Grasp grasp { get; set; }

        public PickupResult()
        {
            this.error_code = new MoveItErrorCodes();
            this.trajectory_start = new RobotState();
            this.trajectory_stages = new RobotTrajectory[0];
            this.trajectory_descriptions = new string[0];
            this.grasp = new Grasp();
        }

        public PickupResult(MoveItErrorCodes error_code, RobotState trajectory_start, RobotTrajectory[] trajectory_stages, string[] trajectory_descriptions, Grasp grasp)
        {
            this.error_code = error_code;
            this.trajectory_start = trajectory_start;
            this.trajectory_stages = trajectory_stages;
            this.trajectory_descriptions = trajectory_descriptions;
            this.grasp = grasp;
        }
    }
}