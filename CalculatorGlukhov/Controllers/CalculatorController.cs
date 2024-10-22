using CalculatorGlukhov.Models;
using CalculatorGlukhov.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorGlukhov.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("multiply")]
        public IActionResult PostMultiply([FromBody] CalculateModel model) {
            try {
                var result = Calculator.Multiply(model.First, model.Second);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("divide")]
        public IActionResult PostDivide([FromBody] CalculateModel model) {
            try {
                var result = Calculator.Divide(model.First, model.Second);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("sum")]
        public IActionResult PostSum([FromBody] CalculateModel model) {
            try {
                var result = Calculator.Sum(model.First, model.Second);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("substract")]
        public IActionResult PostSubstract([FromBody] CalculateModel model) {
            try {
                var result = Calculator.Substract(model.First, model.Second);
                return Ok(result);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }

    }
}
