using LifeApi.Models;
using System.Collections.Generic;

namespace LifeApi.Repositories.Interfaces
{
    public interface IMockLifeApiRepository
    {
        List<Item> GetItemByTitle(string title);

        List<Item> GetItemByName(string name);

        List<Item> GetItemByKeyword(string keyWord);
    }
}