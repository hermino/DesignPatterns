using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.Real.Interfaces
{
    public interface IPizza
    {
        void AddInBox();
        void Cooking();
        void Cutting();
        void Delivery();
        void Prepare();
    }
}
