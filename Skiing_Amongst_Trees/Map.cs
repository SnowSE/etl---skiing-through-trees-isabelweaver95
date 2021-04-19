using System;
using System.Collections.Generic;
using System.Text;

namespace Skiing_Amongst_Trees
{
    class Map
    {
        private int count = 0;
        private char[,] hill = new char[323, 31];
        private int x = 0;
        private int y = 0;


        //constructor 
        public Map()
        {
            hill = extract(hill);
        }



        //this funtion is extracting info from the txt file
        private char[,] extract(char[,] hill)
        {
            string line;


            //read the file//
            //make sure to change the path
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\isabel.weaver\Source\Repos\etl---skiing-through-trees-isabelweaver95\Skiing_Amongst_Trees\TreeMap.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                foreach (char item in line)
                {

                    checkCords();

                    hill[y, x] = item;
                    x++;

                    //this changes the row when x= 31 
                    if (x == 31)
                    {
                        y++;
                    }
                }
            }
            file.Close();
            return hill;
        }


        //I thought we might use this if statements more so we put it into a function
        private void checkCords()
        {
            if (x == 31)
            {
                x = 0;
            }
            if (y == 322)
            {
                y = 0;
            }
        }

        //prints
        public void print()
        {
            for (int i = 0; i < 323; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    System.Console.Write(hill[i, j]);

                }
                System.Console.WriteLine();
            }
        }


        //this function counts the trees we hit
        public int isTree(int x, int y)
        {
            
            //checks if we hit a tree and counts it
            if (hill[y, x] == '#')
            {
                count++;
                if (y == 322)
                {

                }
            }
            return count;
        }

        //this gets count and hill
        public char[,] getHill()
        {
            return hill;
        }
        public int getCount()
        {
            return count;
        }
    }
}