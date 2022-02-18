using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest4
{
    [Test]
    public void MessageRenderer()
    {
        var header = Resources.Header;
        var body = Resources.Body;
        var footer = Resources.Footer;
        var message = new Message(header, body, footer);
        var sut = new MessageRenderer();

        var html = sut.Render(message);

        Assert.True(html.StartsWith("<h1>Lorem ipsum dolor sit amet"));
        Assert.True(html.EndsWith("doloribus asperiores repellat.</i>"));
    }
}
