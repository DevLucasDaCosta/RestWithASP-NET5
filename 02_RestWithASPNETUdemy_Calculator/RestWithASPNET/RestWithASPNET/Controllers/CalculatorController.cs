using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace RestWithASPNET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }
        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);

            return isNumber;
        }
        private double ConvertToDecimal(string strNumber)
        {
            double decimalValue;
            if (double.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            
            return BadRequest("Invalid Input");
        }

        [HttpGet("sub/{firstSubNumber}/{secondSubNumber}")]
        public IActionResult Substract(string firstSubNumber, string secondSubNumber)
        {
            if (IsNumeric(firstSubNumber) && IsNumeric(secondSubNumber))
            {
                var sub = ConvertToDecimal(firstSubNumber) - ConvertToDecimal(secondSubNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("mul/{firstMulNumber}/{secondMulNumber}")]
        public IActionResult Multiplication(string firstMulNumber, string secondMulNumber)
        {
            if (IsNumeric(firstMulNumber) && IsNumeric(secondMulNumber))
            {
                var mul = ConvertToDecimal(firstMulNumber) * ConvertToDecimal(secondMulNumber);
                return Ok(mul.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstDivNumber}/{secondDivNumber}")]
        public IActionResult Division(string firstDivNumber, string secondDivNumber)
        {
            if (IsNumeric(firstDivNumber) && IsNumeric(secondDivNumber))
            {
                var div = ConvertToDecimal(firstDivNumber) / ConvertToDecimal(secondDivNumber);
                return Ok(div.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("ave/{firstAveNumber}/{secondAveNumber}")]
        public IActionResult Average(string firstAveNumber, string secondAveNumber)
        {
            if (IsNumeric(firstAveNumber) && IsNumeric(secondAveNumber))
            {
                var sum = ConvertToDecimal(firstAveNumber) + ConvertToDecimal(secondAveNumber);
                var med = sum / 2;
                return Ok(med.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("sqr/{SqrNumber}")]
        public IActionResult SquareRoot(string SqrNumber)
        {
            if (IsNumeric(SqrNumber))
            {
                var sqr = Math.Sqrt(ConvertToDecimal(SqrNumber));
                return Ok(sqr.ToString());
            }

            return BadRequest("Invalid Input");
        }
    }
}
