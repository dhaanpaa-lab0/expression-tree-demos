using System.Linq.Expressions;

namespace ExtDemo;

public static class ExpressionTreeExt
{
    public static string GetParamName<T>(this Expression<Func<T, object>> expression)
    {
        if (expression.Body is not MemberExpression m) return string.Empty;
        return m.Expression is ParameterExpression p ? p.Name ?? "" : "";
    }
}