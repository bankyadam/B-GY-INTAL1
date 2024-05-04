using System.ComponentModel.DataAnnotations;

namespace B_GY_INTAL1.Enum;

public enum Operator
{
    [Display(Name="+")]
    Add,
    [Display(Name="-")]
    Sub,
    [Display(Name="*")]
    Mul,
    [Display(Name="/")]
    Div
}