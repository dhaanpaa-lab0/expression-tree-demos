using System.Diagnostics;
using System.Linq.Expressions;

namespace ExtDemo;

public class SearchService
{
    
    public string Search<T>(T model, params Expression<Func<T, object>>[] expressions)
    {
        if (expressions.Length <= 0) return string.Empty;

        var parameterName = expressions[0].GetParamName();
        return parameterName;
    }
}