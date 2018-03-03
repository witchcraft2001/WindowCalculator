using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WindowCalc.Models
{
    public enum WindowTypeEnum
    {
        [Description("Глухое")]
        DeadWindow,
        [Description("Поворотное")]
        RotaryWindow,
        [Description("Поворотно-откидное")]
        SwingOutWindow
    }
}
