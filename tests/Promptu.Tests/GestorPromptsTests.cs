using Promptu.Core;
using Xunit;

namespace Promptu.Tests;

public class GestorPromptsTests
{
    [Fact]
    public void Gestor_Se_Crea_Correctamente()
    {
        var gestor = new GestorPrompts();
        Assert.NotNull(gestor);
    }
}
