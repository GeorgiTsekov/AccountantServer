namespace AccountantServer.MVC.Data.BaseModels
{
    public abstract class BaseDeletableModel : BaseModel, IDeletableEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
    }
}
