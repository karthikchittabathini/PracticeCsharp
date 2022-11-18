using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capgDemo_Console
{
    internal class CoordinatesExample
    {
        int x_coordinate;
        int y_coordinate;

        public CoordinatesExample(int xcoordinate, int ycoordinate)
        {
            x_coordinate = xcoordinate;
            y_coordinate = ycoordinate;
        }
        public static CoordinatesExample operator +(CoordinatesExample c1, CoordinatesExample c2)
        {
            return new CoordinatesExample(c1.x_coordinate+c2.x_coordinate, c1.y_coordinate+c2.y_coordinate);
        }

        public override string ToString()
        {
            return $"{x_coordinate}X+{y_coordinate}Y";
        }
        
    }
}
