using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibwareLib
{
    internal class Employee1
	{
			private int empNo;
			private String empName;
			private double salary;

			private double HRA;
			private double TDS;
			private double DA;
			private double PF;
			private double TA;

			private double netSalary;
			private double grossSalary;
		public Employee1(int empNo,String empName,double salary)
        {
			this.empNo = empNo;
			this.empName = empName;
			this.salary = salary;
		}
			public int getEmpNo()
			{
				return empNo;
			}
			public String getEmpName()
			{
				return empName;
			}
			public double getSalary()
			{
				return salary;
			}

			public double calculateGrossSalary()
			{
				try
				{
					if (salary < 5000)
					{
						grossSalary = salary + ((salary / 100) * 10) + ((salary / 100) * 5) + ((salary / 100) * 15);
					}
					else if (salary < 10000)
					{
						grossSalary = salary + ((salary / 100) * 15) + ((salary / 100) * 10) + ((salary / 100) * 20);
					}
					else if (salary < 15000)
					{
						grossSalary = salary + ((salary / 100) * 20) + ((salary / 100) * 15) + ((salary / 100) * 25);
					}
					else if (salary < 20000)
					{
						grossSalary = salary + ((salary / 100) * 25) + ((salary / 100) * 20) + ((salary / 100) * 30);
					}
					else if (salary >= 20000)
					{
						grossSalary = salary + ((salary / 100) * 30) + ((salary / 100) * 25) + ((salary / 100) * 35);
					}
				}
				catch (ArithmeticException e)
				{
					// TODO: handle exception
					Console.WriteLine("Arithmetic Exception Occured", e);

				}
				catch (Exception e)
				{
					Console.WriteLine("Exception occured", e);

					// TODO: handle exception
				}

				return grossSalary;
			}

			public void calculateSalary()
			{
				try
				{
					PF = (grossSalary / 100) * 10;
					TDS = (grossSalary / 100) * 18;
					netSalary = grossSalary - (PF + TDS);
				}
				catch (ArithmeticException e)
				{
					// TODO: handle exception
					Console.WriteLine("Arithmetic Exception Occured", e);

				}
				catch (Exception e)
				{
					Console.WriteLine("Exception occured", e);

					// TODO: handle exception
				}
			
			}
		    public static void Main(String[] args)
			{

				Employee1 S = new Employee1(1001, "sae", 21000.0);
				Console.WriteLine(S.calculateGrossSalary());
				
				S.calculateSalary();
			
				Console.WriteLine("PF: {0}",S.PF);
				Console.WriteLine("TDS: {0}",S.TDS);
				Console.WriteLine("netSalary: {0}",S.netSalary);

			}			
			
	}
	
}
