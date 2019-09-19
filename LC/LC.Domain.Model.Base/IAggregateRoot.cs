using System;

namespace LC.Domain.Model.Base
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
