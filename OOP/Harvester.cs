using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Harvester
    {
        public Harvester(int str, int ave)
        {
            
        }
        private void HarvestField()
        {
            HarvestTwoRows();               //harvest two rows
            PositionForNextHarvest();       //position for next harvest
            HarvestTwoRows();               //harvest two rows
            PositionForNextHarvest();       //position for next harvest
            HarvestTwoRows();               //harvest two rows
        }
        public void HarvestTwoRows()
        {
            HarvestOneRow(); // harvest one row 
            GoToNextRow();   // go to the next row
            HarvestOneRow(); // harvest one row
        }
        public void HarvestOneRow()
        {
            HarvestIntersection();  //harvest an intersection
            move();                 //move      
            HarvestIntersection();  //harvest an intersection
            move();                 //move      
            HarvestIntersection();  //harvest an intersection   
            move();                 //move      
            HarvestIntersection();  //harvest an intersection
            move();                 //move      
            HarvestIntersection();  //harvest an intersection
        }

        
        public void GoToNextRow()
        {
            TurnRight();    //turn right           
            move();         //move             
            TurnRight();    //turn right
        }
        public void PositionForNextHarvest()
        {
            TurnLeft();
            move();
            TurnLeft();
        }
        public void HarvestIntersection()
        {
            PickThing();
        }
        public void move()
        {

        }
        public void TurnRight()
        {

        }
        public void TurnLeft()
        {

        }
        public void PickThing()
        {
            
        }
    }

   
}
