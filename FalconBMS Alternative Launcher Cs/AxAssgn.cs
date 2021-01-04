﻿using System;

namespace FalconBMS_Alternative_Launcher_Cs
{
    /// <summary>
    /// Means each physical axis on a joystick.
    /// </summary>
    public class AxAssgn
    {
        // Member
        protected string axisName = "";     // ex:Roll, Pitch, Yaw etc...
        protected DateTime assgnDate = DateTime.Parse("12/12/1998 12:00:00");
        protected bool invert = false;
        protected AxCurve saturation = 0;
        protected AxCurve deadzone = 0;

        // Property for XML
        public string AxisName { get { return axisName; } set { axisName = value; } }
        public DateTime AssgnDate { get { return assgnDate; } set { assgnDate = value; } }
        public bool Invert { get { return invert; } set { invert = value; } }
        public AxCurve Saturation { get { return saturation; } set { saturation = value; } }
        public AxCurve Deadzone { get { return deadzone; } set { deadzone = value; } }

        // Constructor
        public AxAssgn() { }
        public AxAssgn(string axisName, InGameAxAssgn axisassign)
        {
            this.axisName = axisName;
            assgnDate = DateTime.Now;
            invert = axisassign.GetInvert();
            saturation = axisassign.GetSaturation();
            deadzone = axisassign.GetDeadzone();
        }
        public AxAssgn(string axisName, DateTime assgnDate, bool invert, AxCurve saturation, AxCurve deadzone)
        {
            this.axisName = axisName;
            this.assgnDate = assgnDate;
            this.invert = invert;
            this.saturation = saturation;
            this.deadzone = deadzone;
        }

        // Method
        public string GetAxisName() { return axisName; }
        public DateTime GetAssignDate() { return assgnDate; }
        public bool GetInvert() { return invert; }
        public AxCurve GetDeadZone() { return deadzone; }
        public AxCurve GetSaturation() { return saturation; }

        public AxAssgn Clone()
        {
            return new AxAssgn(axisName, assgnDate, invert, saturation, deadzone);
        }
    }

    public enum AxCurve
    {
        None,
        Small,
        Medium,
        Large
    }
}
