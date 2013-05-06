using System;

namespace YaYu.Data.Contracts
{
    public abstract class BaseEntity
    {
        public virtual Guid Id
        {
            get;
            set;
        }
    }
}