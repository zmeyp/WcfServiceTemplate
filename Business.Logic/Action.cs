using System.Diagnostics;
using Data.Access;

namespace Business.Logic
{
    public class Action : IAction
    {
        private readonly IRepository _repository;

        public Action(IRepository repository)
        {
            _repository = repository;
            Trace.WriteLine("++++++++++++ Constracted Action");
        }

        public string GetData(int value)
        {
            return _repository.GetData(value);
        }
    }
}
