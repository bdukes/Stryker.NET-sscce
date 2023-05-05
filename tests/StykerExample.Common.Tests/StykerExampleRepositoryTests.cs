namespace StykerExample.Common.Tests;

using Xunit;

public class StykerExampleRepositoryTests
{
    [Fact]
    public void CanRetrieveMissingStykerExampleById()
    {
        var maybeStykerExample = new StykerExampleRepository().GetStykerExample(1);
        Assert.Null(maybeStykerExample);
    }
}
