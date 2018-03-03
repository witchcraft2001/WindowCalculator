using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WindowCalc.Models
{
    public enum FittingTypeEnum
    {
        [Description("REHAU Blitz")]
        REHAUBlitz,
        [Description("REHAU Thermolock")]
        REHAUThermolock,
        [Description("REHAU SOLAR")]
        REHAUSolar,
        [Description("REHAU Delight-Design")]
        REHAUDelightDesign,
        [Description("REHAU Brilliant-Design")]
        REHAUBrilliantDesign,
        [Description("KBE Gutwerk")]
        KBEGutwerk,
        [Description("Novotex")]
        Novotex
    }
}
