using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Visitor
{
    internal abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string  Name { get; set; }
        public decimal Salary { get; set; }
    }
    class OrginatinalStructor
    {
        public EmployeeBase Emoloyee;

        public OrginatinalStructor(EmployeeBase firstEmploye)
        {
            Emoloyee = firstEmploye;
        }
        public void Accepr(VisitorBase Visitor)
        {
            Emoloyee.Accept(Visitor);
        }
    }
    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinate = new List<EmployeeBase>();

        }
        public List<EmployeeBase> Subordinate { get; set; }
        public override void Accept(VisitorBase visitor)
        {
           
            visitor.Visit(this);
            foreach (var emoloyee in Subordinate)
            {
                emoloyee.Accept(visitor);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public Worker()
        {
            Subordinate = new List<EmployeeBase>();

        }
        public List<EmployeeBase> Subordinate { get; set; }
        public override void Accept(VisitorBase visitor)
        {
          
            visitor.Visit(this);
        }
    }
    abstract class VisitorBase
    {
        public abstract void Visit(Manager Manager);
        public abstract void Visit(Worker Worker);
    }
    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker Worker)
        {
            Console.WriteLine("{0} paid {1}", Worker.Name, Worker.Salary);
        }
        public override void Visit(Manager Manager)
        {
            Console.WriteLine("{0} paid {1}", Manager.Name, Manager.Salary);
        }
    }
    class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker Worker)
        {
            Console.WriteLine("{0} salary increase  {1}", Worker.Name, Worker.Salary*(decimal)1.1);
        }
        public override void Visit(Manager Manager)
        {
            Console.WriteLine("{0} salary increase  {1}", Manager.Name, Manager.Salary * (decimal)1.1);
        }
    }
}
