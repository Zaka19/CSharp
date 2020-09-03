using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Method
{
    class TableElements
    {
        String[][] TableElements1 = new String[25][];


        public void Table()
        {
            for (int a = 0; a < 100; a++)
            {
                for(int b = 0; b < 100; b++)
                {
                    if(a == 0) { 
                    TableElements1[a][b] = "STONE";
                }
            }
        }
    }
}
