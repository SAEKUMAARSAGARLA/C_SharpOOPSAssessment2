﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    public class Employee
    {
        int EmpNo;
        string EmpName;
        double Salary;
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;
        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
        }
        public int empNo
        {
            get { return EmpNo; }
            set { EmpNo = value; }
        }
        public string empName
        { get { return EmpName; } }
        public double salary { get { return Salary; } set { Salary = value; } }

        public double Grosssalary()
        {
            if (Salary < 5000)
            {
                HRA = ((salary / 100) * 10);
                TA = ((salary / 100) * 5);
                DA = ((salary / 100) * 15);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 10000)
            {
                HRA = ((salary / 100) * 15);
                TA = ((salary / 100) * 10);
                DA = ((salary / 100) * 20);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 15000)
            {
                HRA = ((salary / 100) * 20);
                TA = ((salary / 100) * 15);
                DA = ((salary / 100) * 25);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary < 20000)
            {
                HRA = ((salary / 100) * 25);
                TA = ((salary / 100) * 20);
                DA = ((salary / 100) * 30);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            else if (Salary >= 20000)
            {
                HRA = ((salary / 100) * 25);
                TA = ((salary / 100) * 20);
                DA = ((salary / 100) * 35);
                GrossSalary = ((salary) + (HRA + TA + DA));
            }
            return GrossSalary;
        }
        public void CalculateSalary()
        {
            PF = (GrossSalary / 100) * 10;
            TDS = (GrossSalary / 100) * 18;
            NetSalary = (GrossSalary - (PF + TDS));
        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine("Employee Id " + EmpNo + "\n " + "EmpName-" + EmpName + " \n" + "EmpSal-" + salary + "\n" + "HRA-" + HRA + "\n" + "TA-" + TA + "\n" + "DA-" + DA + "\n" + "PF-" + PF + "\n" + "TDS-" + TDS + "\n" + "NETSALARY-" + NetSalary + "\n" + "GROSS SALARY-" + GrossSalary);
        }
        class Client
        {
            static void Main()
            {
                Employee Obj = new Employee(1002, "saekumaar", 300000);
                Obj.Grosssalary();
                Obj.CalculateSalary();
                Obj.displayEmployeeDetails();
                Console.ReadKey();
            }

        }
    }

    