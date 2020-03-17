using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Library
{
    public class Engine
    {
        public static void Start() 
        {

            DataInputForConsole.DataInput(); //koeffs input, incorresvt input catching
            
            QuadraticTrianominalSolution.GetResult(DataInputForConsole.firstKoeff, DataInputForConsole.secondKoeff, DataInputForConsole.thirdKoeff); // getting a result for equation's solution
            
            SolutionOptions.LinearMultiplesDicompositionApproving(); // if user wants to get decomposition - he will get it

            SolutionOptions.ResultSavingApproving(); // resukt saving
            
            SolutionOptions.NewEquationInputApproving(); //continue with a new equation
        }
    }
}
