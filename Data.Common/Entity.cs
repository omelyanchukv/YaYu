using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YaYu.Shared.Framework.Utilities;

namespace YaYu.Data.Contracts
{
    /// <summary>
    /// Base class for data entities
    /// </summary>
    public class Entity : BaseEntity
    {
        private const int DefaultLongVersion = 0;

        /// <summary>
        /// Unique identifier
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override Guid Id
        {
            get;
            set;
        }

        /// <summary>
        /// Concurrency check property
        /// </summary>
        [Timestamp]
        public byte[] Version
        {
            get;
            set;
        }

        /// <summary>
        /// Determines whether entity is new
        /// </summary>
        [Bindable(false)]
        [ScaffoldColumn(false)]
        public virtual bool IsNew
        {
            get
            {
                return Id == Guid.Empty;
            }
        }

        /// <summary>
        /// EF object state
        /// </summary>
        [Bindable(false)]
        [ScaffoldColumn(false)]
        [NotMapped]
        public virtual EntityState State
        {
            get;
            set;
        }

        public override string ToString()
        {
            return this.DumpToString();
        }
    }
}

