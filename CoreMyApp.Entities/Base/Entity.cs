namespace CoreMyApp.Entities.Base
{
    public abstract class Entity<TKey> : BaseEntity, IEntity<TKey>
    {
        public virtual TKey Id { get; set; }
    }
}