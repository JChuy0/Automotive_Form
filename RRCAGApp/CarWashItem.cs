/******************************************
* Name: Jason Chuy
* Course: BIT, Programming 2, Section 1
* Date Created: April 14, 2020
* Date Last Edited: April 14, 2020
*******************************************/

/**
* Package: Creates an object with the description and cost of an item for use with the CarWashForm.
*
* @author Jason Chuy
* @version 1.0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCAGApp
{
    /// <summary>
    /// Creates an object with the description and cost of an item for use with the CarWashForm.
    /// </summary>
    class CarWashItem : IComparable<CarWashItem>
    {
        private string type;
        private decimal cost;

        public CarWashItem(string type, decimal cost)
        {
            this.type = type;
            this.cost = cost;
        }


        /// <summary>
        /// Gets and sets the value of type.
        /// </summary>
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }


        /// <summary>
        /// Gets and sets the value of cost.
        /// </summary>
        public decimal Cost
        {
            get
            {
                return this.cost;
            }

            set
            {
                this.cost = value;
            }
        }


        /// <summary>
        /// Compares the type of one item to the type of another item.
        /// </summary>
        public int CompareTo(CarWashItem b)
        {
            return this.type.CompareTo(b.type);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Item type is {0}, and the cost is {1}.", this.type, this.cost);
        }


    }
}
