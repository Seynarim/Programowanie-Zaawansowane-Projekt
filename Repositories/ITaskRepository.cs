using Programowanie_Zaawansowane_Projekt.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Programowanie_Zaawansowane_Projekt.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskId);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel task);
        void Update(int taskId, TaskModel task);
        void Delete(int taskId);



    }
}
