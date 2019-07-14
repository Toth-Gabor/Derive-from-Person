using System;
using System.Collections.Generic;

namespace CreateClass
{
    class Program
    {
        public enum Gender { Male, Female }
        public class Person
        {
            private String name;
            private DateTime birthDate;
            private Gender gender;

            public Person(string name, DateTime birthDate, Gender gender)
            {
                this.name = name;
                this.birthDate = birthDate;
                this.gender = gender;
            }

            public string Name { get => name; set => name = value; }
            public DateTime BirthDate { get => birthDate; set => birthDate = value; }
            internal Gender Gender { get => gender; set => gender = value; }

            public override string ToString()
            {
                return "Person name is: " + name + "\nbirthdate: " + birthDate + "\ngender: " + gender;
            }
        }
        public class Employee : Person
        {
            private int Salary;
            private String Profession;
            private Room Room;

            public Employee(string name, DateTime birthDate, Gender gender, int salary, string profession, Room room) : base(name, birthDate, gender)
            {
                Salary = salary;
                Profession = profession;
                Room = room;
            }

            public override string ToString()
            {
                return "Person name is: " + base.Name + "\nbirthdate: " + base.BirthDate + "\ngender: " + base.Gender + "\nsalary: " + Salary
                    + "\nprofession: " + Profession + "\nWorking in room " + Room;
            }
        }

        public class Room
        {
            private int roomNumber;

            public Room(int roomNumber)
            {
                this.roomNumber = roomNumber;
            }

            public int RoomNumber { get => roomNumber; set => roomNumber = value; }

            public override string ToString()
            {
                return roomNumber.ToString();
            }
        }
        static void Main(string[] args)
        {
            var jack = new Employee("Jack", new DateTime(1982, 3, 11), Gender.Male, 11000, "Administrator", new Room(11));
            var pali = new Employee("Pali", new DateTime(1975, 12, 14), Gender.Male, 13000, "Clerk", new Room(13));
            var robi = new Employee("Robi", new DateTime(2000, 3, 22), Gender.Male, 14000, "Receptionist", new Room(9));
            var kati = new Employee("Kati", new DateTime(1976, 6, 1), Gender.Female, 30000, "Director", new Room(22));

            List<Employee> employees = new List<Employee>();
            employees.Add(jack);
            employees.Add(pali);
            employees.Add(robi);
            employees.Add(kati);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
