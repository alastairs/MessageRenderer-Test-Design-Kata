namespace CodingDojo;

public class BodyRenderer : IRenderer
{
    public string Render(Message message) => $"<b>{message.Body}</b>";
}
