using System;
using System.Linq;
using System.Linq.Expressions;

namespace Overt.GrpcTemplate.Application
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
            (Expression.AndAlso(expr1.Body, expr2.Body), expr1.Parameters);
        }
    }
}
