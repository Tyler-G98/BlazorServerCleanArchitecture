public class Robot : BaseAuditableEntity
{
    public string Brand { get; set; }
    public string Name { get; set; }
    public int? Payload { get; set; }
    public int? Reach { get; set; }
}
