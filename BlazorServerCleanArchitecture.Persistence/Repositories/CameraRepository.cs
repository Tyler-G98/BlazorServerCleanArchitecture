using Microsoft.EntityFrameworkCore;

public class CameraRepository : ICameraRepository
{
    private readonly IGenericRepository<Camera> _repository;

    public CameraRepository(IGenericRepository<Camera> repository)
    {
        _repository = repository;
    }

    public Task<List<Camera>> GetCameraByType(string cameraType)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Camera>> GetCameraByTypeAsync(string cityName)
    {
        return await _repository.Entities.Where(x => x.Name == cityName).ToListAsync();
    }
}