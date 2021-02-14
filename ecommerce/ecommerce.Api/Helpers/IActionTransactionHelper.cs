using Microsoft.AspNetCore.Mvc.Filters;

namespace ecommerce.Api.Helpers
{
    public interface IActionTransactionHelper
    {
        void BeginTransaction();
        void EndTransaction(ActionExecutedContext filterContext);
        void CloseSession();
    }
}
