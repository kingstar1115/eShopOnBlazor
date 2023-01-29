﻿using eShopOnBlazor.Models;
using eShopOnBlazor.ViewModel;

namespace eShopOnBlazor.Services;

public interface ICatalogService
{
    CatalogItem? FindCatalogItem(int id);
    IEnumerable<CatalogBrand> GetCatalogBrands();
    PaginatedItemsViewModel<CatalogItem> GetCatalogItemsPaginated(int pageSize, int pageIndex);
    IEnumerable<CatalogType> GetCatalogTypes();
    void CreateCatalogItem(CatalogItem catalogItem);
    void UpdateCatalogItem(CatalogItem catalogItem);
    void RemoveCatalogItem(CatalogItem catalogItem);
}
