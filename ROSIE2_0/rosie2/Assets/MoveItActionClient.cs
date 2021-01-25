﻿/*
© Siemens AG, 2019
Author: Berkay Alp Cakal (berkay_alp.cakal.ct@siemens.com)
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System;
using RosSharp.RosBridgeClient.MessageTypes.ActionlibTutorials;
using RosSharp.RosBridgeClient.MessageTypes.Moveit;
using UnityEngine;

namespace RosSharp.RosBridgeClient.Actionlib
{
    public class MoveItActionClient : ActionClient<MoveGroupAction, MoveGroupActionGoal, MoveGroupActionResult, MoveGroupActionFeedback, MoveGroupGoal, MoveGroupResult, MoveGroupFeedback>
    {
        public int fibonacciOrder;
        public string status = "";
        public string feedback = "";
        public string result = "";

        public MoveItActionClient(string actionName, RosSocket rosSocket)
        {
            this.actionName = actionName;
            this.rosSocket = rosSocket;
            action = new MoveGroupAction();
            goalStatus = new MessageTypes.Actionlib.GoalStatus();
            Debug.Log("Goal Status");
        }

        protected override MoveGroupActionGoal GetActionGoal()
        {
            //action.action_goal.goal = fibonacciOrder;
            return action.action_goal;
        }

        protected override void OnStatusUpdated()
        {
            // Not implemented for this particular application
        }

        protected override void OnFeedbackReceived()
        {
            // Not implemented for this particular application since get string directly returns stored feedback
            Debug.Log("Recieved Feedback");
        }

        protected override void OnResultReceived()
        {
            // Not implemented for this particular application since get string directly returns stored result
        }

        public string GetStatusString()
        {
            if (goalStatus != null)
            {
                return ((ActionStatus)(goalStatus.status)).ToString();
            }
            return "";
        }

        //public string GetFeedbackString()
        //{
        //    if (action != null)
        //        return String.Join(",", action.action_feedback.feedback.sequence);
        //    return "";
        //}

        //public string GetResultString()
        //{
        //    if (action != null)
        //        return String.Join(",", action.action_result.result.sequence);
        //    return "";
        //}
    }
}