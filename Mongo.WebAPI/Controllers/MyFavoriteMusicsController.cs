using Microsoft.AspNetCore.Mvc;
using Mongo.Entities.Models;
using Mongo.Services.Abstract;

namespace Mongo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyFavoriteMusicsController : ControllerBase
    {
        private readonly IUserMusicFavoritesService _userMusicFavoritesService;

        public MyFavoriteMusicsController(IUserMusicFavoritesService userMusicFavoritesService)
        {
            _userMusicFavoritesService = userMusicFavoritesService;
        }

        // GET: api/MyFavoriteMusics
        [HttpGet]
        public IActionResult Get()
        {
            var musics = _userMusicFavoritesService.Get();

            if (musics.Count > 0)
                return Ok(musics);
            else
                return NotFound("Data Not Found");
        }

        // GET: api/MyFavoriteMusics/5
        [HttpGet("{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            var music = _userMusicFavoritesService.GetByUserId(userId);
            if (music != null)
                return Ok(music);
            else
                return NotFound($"{userId} 'Id Not Found");
        }

        // POST: api/MyFavoriteMusics
        [HttpPost]
        public IActionResult Post([FromBody] UserMusicFavorite value)
        {
            _userMusicFavoritesService.Create(value);
            return Ok();
        }

        // PUT: api/MyFavoriteMusics
        [HttpPut]
        public IActionResult Put([FromBody] UserMusicFavorite value)
        {
            _userMusicFavoritesService.Update(value.Id, value);
            return Ok();
        }

        // DELETE: api/MyFavoriteMusics/id
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _userMusicFavoritesService.Remove(id);
            return Ok();
        }
    }
}
