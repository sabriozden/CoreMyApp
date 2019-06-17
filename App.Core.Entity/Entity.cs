using System.ComponentModel.DataAnnotations;

namespace App.Core.Entity
{
    public abstract class Entity<TKey> : BaseEntity, IEntity<TKey>
    {
        [Key]
        public virtual TKey Id { get; set; }
    }
}