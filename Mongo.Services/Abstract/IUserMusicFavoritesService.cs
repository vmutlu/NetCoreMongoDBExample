using Mongo.Entities.Models;
using System.Collections.Generic;

namespace Mongo.Services.Abstract
{
    public interface IUserMusicFavoritesService
    {
        List<UserMusicFavorite> Get();
        UserMusicFavorite GetByUserId(int userId);
        void Remove(string id);
        UserMusicFavorite Create(UserMusicFavorite model);
        void Update(string id, UserMusicFavorite model);
    }
}
