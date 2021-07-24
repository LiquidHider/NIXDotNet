namespace App.Domain.Core
{
    public interface IHaveContactInfo
    {
        string Name { get; set; }
        string ContactNumber { get; set; }
    }
}
