using ComponentBuilder.Parameters;

namespace ComponentBuilder.Bootstrap5;
[HtmlTag("button")]
[CssClass("btn")]
public class Button : BlazorComponentBase, IHasChildContent
{
    [Parameter] public RenderFragment? ChildContent { get; set; }

    /// <summary>
    /// Gets or sets color.
    /// </summary>
    [Parameter][CssClass("btn-")] public Color Color { get; set; }

}
