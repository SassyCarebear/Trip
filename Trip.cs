using System;

namespace TripApp
{
/*
    Program:    Trip
    Developer:  Cara Jones
    Date:       02/26/2022
    Purpose:    Demonstrate the ability to use different classes, constructors, and methods.  
*/
    public class Trip
    {
    #region all private attributes
        private string destination;
        private decimal distanceTraveled;
        private decimal gallonsConsumed;
        private decimal totalCostOfGas;
    #endregion


    #region Getters and Setters
        public string Destination
        {
            get{return destination;}
            set{destination = value;}
        }//end of Destination
        public decimal DistanceTraveled
        {
            get{return distanceTraveled;}
            set{distanceTraveled = value;}
        }//end of DistanceTraveled
        public decimal GallonsConsumed
        {
            get{return gallonsConsumed;}
            set{gallonsConsumed = value;}
        }
        public decimal TotalCostOfGas
        {
            get{return totalCostOfGas;}
            set{totalCostOfGas = value;}
        }
    #endregion

    #region constructors
        public Trip(string destination, decimal distanceTraveled, decimal gallonsConsumed, decimal totalCostOfGas)
        {
            this.destination = destination;
            this.distanceTraveled = distanceTraveled;
            this.gallonsConsumed = gallonsConsumed;
            this.totalCostOfGas = totalCostOfGas;

        }//end of Trip
        #endregion
        public decimal Miles()
        {   
            decimal miles = this.distanceTraveled / this.gallonsConsumed;
            return miles; 
        }// end of MilesPerGallon calculation
        public decimal Cost()
        {
            decimal cost = this.totalCostOfGas / this.distanceTraveled;
            return cost;
        }
  

        
        public override string ToString()
        {
            decimal milesPerGallon = Miles();
            decimal costPerMile = Cost();
            return string.Format(  "A trip to {0} is {1} miles away.  \n"
                                +   "Gallons of Gas Consumed:   {2}   \n" +
                                    "Miles Per Gallon:          {3}   \n" +
                                    "Cost Per Mile:             {4:c} \n" +
                                    "Total Cost of Gas:         {5:c} \n\n", destination, 
                                    Convert.ToInt16(distanceTraveled), 
                                    Convert.ToInt16(gallonsConsumed), 
                                    milesPerGallon, costPerMile, totalCostOfGas);
 
        }//end of ToString
    }//end of class
}// end of solution
