//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

namespace Machine.Specifications.Mvc.Specs
{
    using System;
    using System.Linq.Expressions;

    [Subject(typeof(ExpressionActionExtensions))]
    public class when_the_expression_action_extensions_is_asked_for_the_method_body_name
    {
        static string result;
        static Expression<Action<HomeController>> action;

        Establish context = () =>
            {
                action = (x => x.Index());
            };

        Because of = () => result = action.GetMethodBodyName();

        It should_return_the_name_of_the_method_body = () => result.ShouldEqual("Index");
    }

    [Subject(typeof(ControllerExtensions))]
    public class when_the_expression_action_extensions_is_asked_for_the_method_body_name_and_the_action_is_null
    {
        static Expression<Action<HomeController>> action;
        static Exception exception;

        Establish context = () =>
        {
            action = null;
        };

        Because of = () => exception = Catch.Exception(() => action.GetMethodBodyName());

        It should_throw_an_exception = () => exception.ShouldBeOfType<SpecificationException>();
    }
}   