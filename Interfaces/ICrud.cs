using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTaskApp.Interfaces
{
    public interface ITaskCRUD 
    {


        void Add();

        void Update();

        void Delete();
    }
}
