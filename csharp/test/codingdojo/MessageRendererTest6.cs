using ApprovalTests;
using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest6
{
    [Test]
    public void message_renderer()
    {
        var message = new Message("header", "body", "footer");
        var sut = new MessageRenderer();

        var html = sut.Render(message);

        Approvals.Verify(html);
    }
}
