public class GetAllCamerasDto : IMapFrom<Camera>
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public int? Type { get; set; }
    public int? Resolution { get; set; }
}
