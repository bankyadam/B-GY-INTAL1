using System.ComponentModel.DataAnnotations;
using B_GY_INTAL1.Enum;

namespace B_GY_INTAL1.Models;

public class OperationModel
{
    [Required] public int A { get; set; }
    [Required] public int B { get; set; }
    [Required] public Operator Operator { get; set; }

    public float Result { get; set; }
}