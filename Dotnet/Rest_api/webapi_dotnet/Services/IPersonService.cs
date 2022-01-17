using System;
using webapi_dotnet.Model;
using System.Collections.Generic;


namespace webapi_dotnet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person Update(Person person);

        void Delete(long Id);

        Person FindById(long Id);

        List<Person> Findall();
        
    }
}
