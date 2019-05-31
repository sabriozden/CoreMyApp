using System.ComponentModel.DataAnnotations;

namespace CoreMyApp.Entities.Base
{
    public abstract class Entity<TKey> : BaseEntity, IEntity<TKey>
    {
        [Key]
        public virtual TKey Id { get; set; }
    }
}