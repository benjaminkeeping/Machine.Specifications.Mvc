//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

namespace Machine.Specifications.Mvc.Specs
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class context_for_redirect_to_route_result_extensions
    {
        protected static RedirectToRouteResult redirectToRouteResult;

        Establish context = () =>
        {
            redirectToRouteResult =
                new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Index" }));
        };
    }
    
    [Subject(typeof(RedirectToRouteResultExtensions))]
    public class when_a_redirect_to_route_result_is_asked_for_the_controller_name : context_for_redirect_to_route_result_extensions
    {
        static string result;

        Because of = () => result = redirectToRouteResult.ControllerName();

        It should_return_the_controller_name = () => result.ShouldEqual("Home");
    }

    [Subject(typeof(RedirectToRouteResultExtensions))]
    public class when_a_redirect_to_route_result_is_asked_for_the_action_name : context_for_redirect_to_route_result_extensions
    {
        static string result;

        Because of = () => result = redirectToRouteResult.ActionName();

        It should_return_the_controller_name = () => result.ShouldEqual("Index");
    }
}   