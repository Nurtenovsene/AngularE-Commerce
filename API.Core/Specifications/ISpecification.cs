

using System.Linq.Expressions;

namespace API.Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }//ne kadar gösterilecek
        int Skip { get; }//ne kadar atlanacak
        bool IsPagingEnabled { get; }//sayfalama olacak mı olmayacak mı

    }
}
