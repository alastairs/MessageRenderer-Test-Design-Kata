
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
