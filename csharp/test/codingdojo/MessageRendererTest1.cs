using System.Linq;
using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest1
{
    [Test]
    public void MessageRenderer()
    {
        var sut = new MessageRenderer();

        var renderers = sut.Renderers.ToList();
        Assert.AreEqual(3, renderers.Count);
        Assert.IsInstanceOf<HeaderRenderer>(renderers[0]);
        Assert.IsInstanceOf<BodyRenderer>(renderers[1]);
        Assert.IsInstanceOf<FooterRenderer>(renderers[2]);
    }
}
