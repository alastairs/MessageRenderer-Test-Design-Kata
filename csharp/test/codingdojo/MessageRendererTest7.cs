using System.Collections.Generic;
using System.IO;
using System.Linq;
using AngleSharp.Html.Dom.Events;
using AngleSharp.Html;
using AngleSharp.Html.Parser;
using NUnit.Framework;

namespace CodingDojo.Tests;

public class MessageRendererTest7
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

        var errors = new List<HtmlErrorEvent?>();
        var tidy = new HtmlParser();
        tidy.AddEventListener("error", (_, error) => errors.Add(error as HtmlErrorEvent));
        var output = new StringWriter();
        var dom = tidy.ParseDocument(html);

        // We expect an error about a missing doctype
        Assert.AreEqual(1, errors.Count, string.Join(", ", errors.Select(e => e?.Message)));
        Assert.True(dom.HasChildNodes);
        dom.ToHtml(output, new PrettyMarkupFormatter());
        Assert.AreEqual(Resources.ExpectedHtml, output.ToString());
    }
}
