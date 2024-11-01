﻿using ECommerceShared;
using ECommerceShared.Dtos;
using ECommerceShared.Entites;

namespace ECommerceMvc.Services.Abstract
{
    public interface ICategoryService
    {
        Task<ServiceResponse<CategoryDto>> CreateCategory(CategoryDto request);
        Task<ServiceResponse<bool>> DeleteCategory(int categoryId);
        Task<ServiceResponse<CategoryDto>> GetCategory(int categoryId);
        Task<ServiceResponse<CategoryDto>> UpdateCategory(int categoryId, CategoryDto categoryDto);
        Task<ServiceResponse<List<Category>>> ListCategory();
        List<Category> GetCategories();
        Task<Category> GetCategoryByName(string categoryName);
    }
}
