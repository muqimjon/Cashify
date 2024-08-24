namespace Cashify.Domain.Common;

public abstract class Auditable
{
    public long Id { get; set; }
    public DateTimeOffset CteatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}