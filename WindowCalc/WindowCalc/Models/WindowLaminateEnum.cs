using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WindowCalc.Models
{
    public enum WindowLaminateEnum
    {
        [Description("Нет")]
        None,
        [Description("Односторонняя")]
        Single,
        [Description("Двусторонняя")]
        All
    }
}
