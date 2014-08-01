using System;

namespace MyCoach.Business.Domain.Model
{
    public class Entity<TEntity> : IEntity, IEquatable<TEntity>
        where TEntity : class, IEntity
    {
        public int Id { get; private set; }

        public bool Equals(TEntity other)
        {
            if (other == null)
            {
                return false;
            }

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Entity<TEntity>;

            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity<TEntity> entity1, Entity<TEntity> entity2)
        {
            if ((object)entity1 == null || ((object)entity2) == null)
            {
                return Equals(entity1, entity2);
            }

            return entity1.Equals(entity2);
        }

        public static bool operator !=(Entity<TEntity> entity1, Entity<TEntity> entity2)
        {
            if (entity1 == null || entity2 == null)
            {
                return !Equals(entity1, entity2);
            }

            return !(entity1.Equals(entity2));
        }
    }
}