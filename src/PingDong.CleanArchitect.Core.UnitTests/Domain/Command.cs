using Xunit;

namespace PingDong.CleanArchitect.Core.UnitTests
{
    public class CommandTest
    {
        [Fact]
        public void Command_EmptyCtor()
        {
            var evt = new Command();

            Assert.Null(evt.CorrelationId);
        }

        [Fact]
        public void Command_WithCorrelationId()
        {
            var evt = new Command("Test");

            Assert.Equal("Test", evt.CorrelationId);
        }

        [Fact]
        public void Command_Property_CorrelationId()
        {
            var evt = new Command
            {
                CorrelationId = "Test"
            };

            Assert.Equal("Test", evt.CorrelationId);
        }
    }
}
