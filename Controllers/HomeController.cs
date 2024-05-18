using B_GY_INTAL1.Enum;
using Microsoft.AspNetCore.Mvc;
using B_GY_INTAL1.Models;

namespace B_GY_INTAL1.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Step2(OperationModel operationModel)
    {
        switch (operationModel.Operator)
        {
            case Operator.Add:
                operationModel.Result = operationModel.A + operationModel.B;
                break;
            case Operator.Sub:
                operationModel.Result = operationModel.A - operationModel.B;
                break;
            case Operator.Mul:
                operationModel.Result = operationModel.A * operationModel.B;
                break;
            case Operator.Div:
                if (operationModel.B != 0)
                    operationModel.Result = operationModel.A / operationModel.B;
                else
                    throw new ArithmeticException();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        return View(operationModel);
    }
}