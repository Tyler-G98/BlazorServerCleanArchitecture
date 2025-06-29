public interface ICameraRepository
{
    Task<List<Camera>> GetRobotByTypeAsync(string cameraType);
}

