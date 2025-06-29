public interface ICameraRepository
{
    Task<List<Camera>> GetCameraByType(string cameraType);
}

