using Entities.Concrete;

namespace Business.Concrete
{
    internal class ValidatonContext<T>
    {
        private Product product;

        public ValidatonContext(Product product)
        {
            this.product = product;
        }
    }
}