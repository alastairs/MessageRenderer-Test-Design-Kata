using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest5
{
    [Test]
    public void MessageRenderer()
    {
        var sut = new MessageRenderer();

        var renderers = sut.Renderers;

        Assert.NotNull(sut);
        Assert.NotNull(renderers);
    }
}
