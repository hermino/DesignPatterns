using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Real.Interfaces
{
    public interface IPizza
    {
        string AddInBox();
        string Cooking();
        string Cutting();
        string Delivery();
        string Prepare(List<string> ingredients);
    }
}
