using System;
using System.IO;
using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest2 {

    [Test]
    public void MessageRenderer() {

        var sourceCode = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "../../../../..", "src", "codingdojo",  "MessageRenderer.cs"));
        Assert.AreEqual(sourceCode, @"
using System.Text;

namespace CodingDojo;

public class MessageRenderer : IRenderer
{
    public IEnumerable<IRenderer> Renderers { get; }

    public MessageRenderer() =>
        Renderers = new List<IRenderer>
        {
            new HeaderRenderer(),
            new BodyRenderer(),
            new FooterRenderer()
        };

    public string Render(Message message) =>
        Renderers.Select(x => x.Render(message))
            .Aggregate(new StringBuilder(), (builder, section) => builder.Append(section))
            .ToString();
}
");
    }
}
