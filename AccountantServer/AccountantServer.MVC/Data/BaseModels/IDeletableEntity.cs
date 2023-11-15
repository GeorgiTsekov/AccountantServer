namespace AccountantServer.MVC.Data.BaseModels
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }
        string? DeletedBy { get; set; }
        DateTime? DeletedOn { get; set; }
    }
}
