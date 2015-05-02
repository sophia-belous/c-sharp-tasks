using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DinamicLib
{
    public static class DynamicQueryable
    {
        public static IQueryable<T> DynamicWhere<T>(this IQueryable<T> queryableData, Expression<Func<T, bool>> expression)
        {
            if (queryableData == null) throw new ArgumentNullException("queryableData");

            MethodCallExpression whereCallExpression = Expression.Call(
                typeof(Queryable),
                "Where",
                new Type[] { queryableData.ElementType },
                queryableData.Expression,
                expression);
            return queryableData.Provider.CreateQuery<T>(whereCallExpression);
        }

        public static IQueryable<T> DynamicOrderBy<T>(this IQueryable<T> queryableData, Expression<Func<T, T>> expression)
        {
            if (queryableData == null) throw new ArgumentNullException("queryableData");

            MethodCallExpression orderByCallExpression = Expression.Call(
                typeof(Queryable),
                "OrderBy",
                new Type[] { queryableData.ElementType, queryableData.ElementType },
                queryableData.Expression,
                expression);
            return queryableData.Provider.CreateQuery<T>(orderByCallExpression);
        }

        public static IQueryable<T> DynamicOrderByDescending<T>(this IQueryable<T> queryableData, Expression<Func<T, T>> expression)
        {
            if (queryableData == null) throw new ArgumentNullException("queryableData");

            MethodCallExpression orderByCallExpression = Expression.Call(
                typeof(Queryable),
                "OrderByDescending",
                new Type[] { queryableData.ElementType, queryableData.ElementType },
                queryableData.Expression,
                expression);
            return queryableData.Provider.CreateQuery<T>(orderByCallExpression);
        }

        public static IQueryable<T> DynamicTake<T>(this IQueryable<T> queryableData, int count)
        {
            if (queryableData == null) throw new ArgumentNullException("queryableData");

            MethodCallExpression takeCallExpression = Expression.Call(
                typeof(Queryable),
                "Take",
                new Type[] { queryableData.ElementType },
                queryableData.Expression,
                Expression.Constant(count));

            return queryableData.Provider.CreateQuery<T>(takeCallExpression);
        }
    }
}
