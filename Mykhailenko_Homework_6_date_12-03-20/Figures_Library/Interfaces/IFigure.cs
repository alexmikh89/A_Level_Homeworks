using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_Library
{
    public interface IFigure
    {
        double Perimeter { get; }
        double Area { get; }
        string Name { get; set; }
    }


    interface ICircle : IFigure
    {
        double Radius { get; set; }
    }


    interface ISquare : IFigure
    {
        double SideLength { get; set; }
    }


    interface IRectangle : IFigure
    {
        double FirstSideLength { get; set; }
        double SecondSideLength { get; set; }
    }


    interface ITriangle : IFigure
    {
        double FirstSideLength { get; set; }
        double SecondSideLength { get; set; }
        double ThirdSideLength { get; set; }
    }
}
