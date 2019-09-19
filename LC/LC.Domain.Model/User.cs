using System;
using LC.Domain.Model.Base;

namespace LC.Domain.Model
{
    public class User: IAggregateRoot
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }
        public static User Create(string name)
        {
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Name = name
            };

            return user;
        }
    }
}
