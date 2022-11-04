using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.RequestModels
{
    public class CreateUserCommand:IRequest<Guid>
    {
        public string FirstName { get; set; }   // Warning CS8618  Non-nullable property 'FirstName' must contain a non-null value when exiting constructor.Consider declaring the property as nullable.... if get this warning i can <Nullable>disable</Nullable> in .csproj file

        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
