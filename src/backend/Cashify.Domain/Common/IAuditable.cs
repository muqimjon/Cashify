namespace Cashify.Domain.Common;

public interface IAuditable
{
    long Id { get; set; }
    DateTimeOffset CteatedAt { get; }
    DateTimeOffset? UpdatedAt { get;}
}