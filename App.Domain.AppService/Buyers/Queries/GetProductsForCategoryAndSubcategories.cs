using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;
using App.Domain.Core.Services.Buyers.Queries;
using App.Infrastructures.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Buyers.Queries
{
    public class GetProductsForCategoryAndSubcategories : IGetProductsForCategoryAndSubcategories
    {
        private readonly IProductRepository _productRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly IStoreRepository _storeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public GetProductsForCategoryAndSubcategories(IProductRepository productRepository, ISellerRepository sellerRepository,
                                                     IStoreRepository storeRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _sellerRepository = sellerRepository;
            _storeRepository = storeRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<ProductDto>> Execute(int parentCategoryId, CancellationToken cancellationToken)
        {
            List<ProductDto> products = new List<ProductDto>();
            await GetProductsRecursive(parentCategoryId, products, cancellationToken);

            foreach (var product in products)
            {
                product.SellerName = (await _sellerRepository.GetById(product.StoreId, cancellationToken)).FirstName + " " +
                                      (await _sellerRepository.GetById(product.StoreId, cancellationToken)).LastName;
                product.StoreTitle = (await _storeRepository.GetById(product.StoreId, cancellationToken)).Title;
            }
            return (products.Where(p => !p.IsAuction && p.Stock > 0)).ToList();
        }


        private async Task GetProductsRecursive(int categoryId, List<ProductDto> products, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetById(categoryId, cancellationToken);

            //products related to the same category
            category.Products = await _productRepository.GetAllByCategoryId(categoryId, cancellationToken);

            //subCategories related to the same category
            category.SubCategories = (await _categoryRepository.GetAll(cancellationToken)).Where(c => c.ParentId == categoryId).ToList();

            if (category != null)
            {
                products.AddRange(category.Products);

                foreach (var subCategory in category.SubCategories)
                {
                    await GetProductsRecursive(subCategory.Id, products, cancellationToken);
                }
            }
        }

    }
}