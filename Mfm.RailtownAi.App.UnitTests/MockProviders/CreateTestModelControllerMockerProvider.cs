using Mfm.RailtownAi.Domain.Models;

namespace Mfm.RailtownAi.App.UnitTests.MockProviders
{
    internal class CreateTestModelControllerMockerProvider
    {
        public static string MockedErrorMessage = "MockedErrorMessage";
        public static TestModel MockedTestModel = new TestModel
        {
            Test = ""
        };
    }
}
