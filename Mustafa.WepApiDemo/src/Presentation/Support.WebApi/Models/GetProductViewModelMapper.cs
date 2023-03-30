using Support.Application.Business.Models;

namespace Support.WebApi.Models
{
    public interface IGetProductViewModelMapper
    {
        List<GetProductViewModel> MapProduct(IList<GetProductModel> getProduct);
    }
    public class GetProductViewModelMapper : IGetProductViewModelMapper
    {
        public List<GetProductViewModel> MapProduct(IList<GetProductModel> getProduct)
        {
            return getProduct.Select(x => new GetProductViewModel
            {
                CategoryId = x.CategoryId,
                Code = x.Code,
                CreatedOn = x.CreatedOn,
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
