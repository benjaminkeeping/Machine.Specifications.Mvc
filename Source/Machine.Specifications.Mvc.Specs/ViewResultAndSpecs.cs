//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

namespace Machine.Specifications.Mvc.Specs
{
    using System.Web.Mvc;

    [Subject(typeof(ViewResultAnd))]
    public class when_the_view_result_and_is_asked_for_the_and_bit
    {
        static ViewResultAnd viewResultAnd;
        static ViewResult viewResult;
        static ViewResult result;

        Establish context = () =>
            {
                viewResult = new ViewResult();
                viewResultAnd = new ViewResultAnd(viewResult);
            };

        Because of = () => result = viewResultAnd.And();

        It should_return_the_view_result = () => result.ShouldEqual(viewResult);
    }
}   