using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.State
{
    class ModifiedState : IState
    {
        public void DoAction(Context Context)
        {
            Console.WriteLine("State Modified");
            Context.SetState(this);
        }
        public override string ToString()
        {
            return "Modified";
        }
    }
    class AddeddState : IState
    {
        public void DoAction(Context Context)
        {
            Console.WriteLine("State added");
            Context.SetState(this);
        }
        public override string ToString()
        {
            return "Added";
        }
    }
    class DeletedState : IState
    {
        public void DoAction(Context Context)
        {
            Console.WriteLine("State delete");
            Context.SetState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }               
    }
    interface IState
    {
        void DoAction(Context Context);
       
    }
    class Context
    {
        private IState _state;
        public void  SetState(IState State)
        {
            _state = State;

        }
        public IState GetState()
        {
            return _state;
        }

    }

}
