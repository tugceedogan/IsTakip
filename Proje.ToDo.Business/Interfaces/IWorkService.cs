using System;
using Proje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Interfaces
{
    public interface IWorkService : IGenericService<Work>
    {
        List<Work> GetirAciliyetIleTamamlanmayan();
        List<Work> GetAllTable();
        Work GetirAciliyetIleId(int id);
    }
}
