using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {
        private List<Employee> employees;

        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.employees = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => employees.Count;

        public void Add(Employee employee)
        {
            if (Count < Capacity)
            {
                employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = employees.FirstOrDefault(x => x.KruvnaGrupa == name);

            if (employee != null)
            {
                employees.Remove(employee);
                return true;
            }

            return false;
        }

        public Employee GetOldestEmployee()
        {
            return employees.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Employee GetEmployee(string name)
        {
            return employees.FirstOrDefault(x => x.KruvnaGrupa == name);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");

            foreach (var item in employees)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
