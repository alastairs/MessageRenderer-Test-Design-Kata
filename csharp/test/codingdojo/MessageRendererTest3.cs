using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest3
{
    [Test]
    public void MessageRenderer()
    {
        var sut = new MessageRenderer();
        var message = new Message("h", "b", "f");
        string html = sut.Render(message);
        Assert.AreEqual("<h1>h</h1><b>b</b><i>f</i>", html);
    }
}
