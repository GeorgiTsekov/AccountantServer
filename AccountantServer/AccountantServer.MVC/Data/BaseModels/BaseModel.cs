using System.ComponentModel.DataAnnotations;

namespace AccountantServer.MVC.Data.BaseModels
{
    public abstract class BaseModel : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedOn { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public string? ModifiedBy { get; set; } = string.Empty;
    }
}
