using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentCalculatorWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CalculationController : Controller
    {
        [HttpGet]
        [ActionName("Addition")]
        public double add( double leftNumber, double rightNumber)
        {
            return Calculator_ClassLibrary.LibCalculator.add(leftNumber,rightNumber);
        }

        [HttpGet]
        [ActionName("Subtraction")]
        public double sub(double leftNumber, double rightNumber)
        {
            return Calculator_ClassLibrary.LibCalculator.sub(leftNumber, rightNumber);
        }


        [HttpGet]
        [ActionName("Multiplication")]
        public double mul(double leftNumber, double rightNumber)
        {
            return Calculator_ClassLibrary.LibCalculator.mul(leftNumber, rightNumber);
        }


        [HttpGet]
        [ActionName("Division")]
        public double div(double leftNumber, double rightNumber)
        {
            return Calculator_ClassLibrary.LibCalculator.div(leftNumber, rightNumber);
        }
    }
}
