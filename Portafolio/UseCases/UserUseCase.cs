using Portafolio.Models;
using Portafolio.UseCases.Abstract;
using System.Collections.Generic;

namespace Portafolio.UseCases
{
    public class UserUseCase : AbstractRepository<User>
    {
        public UserUseCase(TaskContext context)
            : base(context, context.Users)
        {
        }

        public int Count() => _set.Count;
    }
}
