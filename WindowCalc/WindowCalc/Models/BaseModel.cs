using System;
using System.Collections.Generic;
using System.Text;
using WindowCalc.Helpers;

namespace WindowCalc.Models
{
    public class BaseModel : ObservableObjects
    {        
        /// <summary>
        /// Id for item
        /// </summary>
        public int Id { get; set; }   
    }
}
