using System;
using System.Collections.Generic;
using System.Text;

namespace WindowCalc.Models
{
    public class WindowType : BaseModel
    {
        private String image;
        private String description;

        public String Image
        {
            get { return image; }
            set { SetProperty(ref image, value); }
        }

        public String Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
    }
}
