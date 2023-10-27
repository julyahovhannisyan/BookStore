using BookStore.Core.Common.Enum;

namespace BookStore.Core.Common
{
    public interface IProduct : IBaseModel
    {
        public decimal Price { get; set; }
        public Category CategoryName { get; set; }
    }
}
