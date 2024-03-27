﻿
using Microsoft.EntityFrameworkCore;

namespace GameZon.Services
{
    public class GamesService : IGamesService
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _imagesPath;

        public GamesService(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _imagesPath = $"{_webHostEnvironment.WebRootPath}{FileSetting.ImagesPath}";
        }
        public IEnumerable<Game> GetAll()
        {
            return _context.Games
            .Include(g => g.Category)
            .Include(g => g.Devices)
            .ThenInclude(d => d.Device)
            .AsNoTracking()
            .ToList();
        }
        public Game? GetById(int id)
        {
            return _context.Games
                .Include(g => g.Category)
                .Include(g => g.Devices)
                .ThenInclude(d => d.Device)
                .AsNoTracking()
                .SingleOrDefault(g => g.Id == id);
        }
        public async Task Create(CreateGameFormViewModel model)
        {
           var coverName=$"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";
            var path =  Path.Combine(_imagesPath, coverName);
        using var straem=File.Create(path); 
        await model.Cover.CopyToAsync(straem);
          
            Game game = new Game()
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Cover = coverName
                ,Devices = model.SelectedDevices.Select(d => new GameDevice { DeviceId = d }).ToList()

            };
            _context.Add(game);
            _context.SaveChanges(); 

        }

        
    }
}
