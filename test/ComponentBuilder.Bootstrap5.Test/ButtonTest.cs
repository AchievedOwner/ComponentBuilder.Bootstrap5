namespace ComponentBuilder.Bootstrap5.Test;
public class ButtonTest : TestBase
{
    [Fact]
    public void Test_Button_Render()
    {
        Context.RenderComponent<Button>()
            .MarkupMatches("<button class=\"btn btn-primary\"></button>");
    }
}
