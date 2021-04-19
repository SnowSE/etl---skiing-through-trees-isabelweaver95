using System;
using System.Collections.Generic;
using System.Text;

namespace Skiing_Amongst_Trees
{
    class Ski
    {

        private int slopeX;
        private int slopeY;
        private int positionX = 0;
        private int positionY = 0;


        public Ski(int slopex, int slopey)
        {
            slopeX = slopex;
            slopeY = slopey;

            //check if the input is a negitave number
            if (slopeX <= 0 || slopeY <= 0)
            {
                System.Console.WriteLine("Invalid, negitive slope! Cant go up!");
                Environment.Exit(0);
            }


        }


        //this is the get position functions. they just return the where the skier is
        public int getPositionX()
        {
            return positionX;
        }
        public int getPositionY()
        {
            return positionY;
        }


        //this is moving the postion of the skier
        public void movePosition()
        {

            if (positionY + slopeY <= 322)
            {
                positionX += slopeX;
                positionY += slopeY;
            }


            if (positionX >= 31)
            {
                //looping back to the beginning of the positionX
                positionX = (positionX - 31);

            }
            else if (positionY + slopeY >= 322)
            {
                //this just makes it so the positionY when grater than the bounds it will equal 322.S
                positionY = 322;
            }
        }


    }
}