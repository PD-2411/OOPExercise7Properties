using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMADPartyStore
{
    public class Balloon
    {
        //My Balloon Private Fields
        private string colour;
        private int height;
        private int diameter;

        public string Colour
        {
            get { return colour; }
            set
            {
                //Limit to red white or blue balloons
                if (value.ToUpper() == "RED" || value.ToUpper() == "BLUE" || value.ToUpper() == "WHITE")
                {
                    colour = value;
                }
                else
                {
                    throw new DataException("Colour must be red, white or blue");
                }
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (colour.ToUpper() == "RED")
                {
                    if (value >= 12)
                    {
                        diameter = value;
                    }
                    else
                    {
                        throw new ConstraintException("Red Balloon must be at least 12 inches");
                    }
                }
                else if (colour.ToUpper() == "WHITE")
                {
                    if (value >= 10)
                    {
                        diameter = value;
                    }
                    else
                    {
                        throw new ConstraintException("White Balloon must be at least 10 inches");
                    }
                }
                else
                {
                    if(value > 0)
                    {
                        diameter = value;
                    }
                    else
                    {
                        throw new ConstraintException("Balloons must have diameter greater than zero");
                    }
                }

            }
        }
    }
}
