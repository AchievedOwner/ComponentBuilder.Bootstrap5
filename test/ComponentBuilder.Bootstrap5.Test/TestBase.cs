namespace ComponentBuilder.Bootstrap5.Test;
public abstract class TestBase
{
    private readonly TestContext _testContext;
    public TestBase()
    {
        _testContext = new TestContext();

        _testContext.Services.AddBootstrap5();
    }

    public TestContext Context => _testContext;
}
