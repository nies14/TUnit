namespace TUnit.Engine.SourceGenerator.Tests;

public class OrderedTests : TestsBase
{
    [Test]
    public Task Test() => RunTest(Path.Combine(Git.RootDirectory.FullName,
            "TUnit.TestProject",
            "OrderedTests.cs"),
        generatedFiles =>
        {
            Assert.That(generatedFiles.Length, Is.EqualTo(6));
            
            Assert.That(generatedFiles[0], Does.Contain("TestName = \"Second\","));
            Assert.That(generatedFiles[0], Does.Contain("Order = 2,"));
            
            Assert.That(generatedFiles[1], Does.Contain("TestName = \"Fourth\","));
            Assert.That(generatedFiles[1], Does.Contain("Order = 4,"));
            
            Assert.That(generatedFiles[2], Does.Contain("TestName = \"First\","));
            Assert.That(generatedFiles[2], Does.Contain("Order = 1,"));
            
            Assert.That(generatedFiles[3], Does.Contain("TestName = \"Fifth\","));
            Assert.That(generatedFiles[3], Does.Contain("Order = 5,"));
            
            Assert.That(generatedFiles[4], Does.Contain("TestName = \"Third\","));
            Assert.That(generatedFiles[4], Does.Contain("Order = 3,"));
            
            Assert.That(generatedFiles[5], Does.Contain("TestName = \"AssertOrder\","));
            Assert.That(generatedFiles[5], Does.Contain("Order = 6,"));
        });
}