using Machine.Specifications;

namespace BirthdayGreetingsKata.Tests
{
    [Subject("Testing")]
    public class When_the_program_beings
    {
        Establish context = () =>
        {
            Subject = new Greeter();
        };

        Cleanup after = () =>
        {
            Subject.Dispose();
        };

        static Greeter Subject;
        static string response;

        Because of = () => response = Subject.Greet("JC");

        It should_say_correct_name = () => response.ShouldEqual("Hey, JC!");
    }
}
