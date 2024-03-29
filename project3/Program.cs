
namespace numbers
{
    class safetyCasting
    {
        public static void Main(String[] args)
        {
            // SafetyCasting();
            int val=10;
            int j = val;
            j = 11;
            object ob = val;
            ob = 12;
            String s = new String("sing");
            s = "signature";
            Object o1 = s;
            int[] ar = { 1, 2, 3, 4 };
            o1 = "sign";
            object obj = new Hr(1200, "gfirjj");
            Employee e=(Employee)obj;
            Console.WriteLine(e.id);

            Console.WriteLine(val);
            Console.WriteLine(j);
            Console.WriteLine(ob.ToString());
            Console.WriteLine(val);
            Console.WriteLine(o1);
            Console.WriteLine(s);
            Console.WriteLine(obj);
            Console.WriteLine(obj is Hr);

           


            // Employee emp = new Hr(1168, "dharani");
            // emp.printEmployee();
            // emp.printId();


            // emp.display(out val);
        }
        public void printObject()
        {
            Console.WriteLine();
        }
        //public static void SafetyCasting()
        //{
        //  Object obj=new Object();

        //  Employee emp = new Employee();


        //    Employee emp1 =(Employee) (obj as Employee);
        //    Console.WriteLine(emp1);

        // }
    }
    abstract class  Employee
    {
        public int id;
        public String name;
        public static double rateOfInterest;

        public Employee()
        {

        }

        public Employee(int id,String name)
        {
            this.id = id;
            this.name = name;

        }

        static Employee()
        {
            rateOfInterest = 9.5;
        }

        public  void display(out int val)
        {
            val = 25;
            Console.WriteLine(id+" "+name+" "+rateOfInterest+" "+ val);
        }
        
        public virtual void printEmployee()
        {
            Console.WriteLine(name);
        }

        public abstract void printId(); 

       
    }

    class Hr : Employee
    {

        public Hr(int id,String name)
        {
            base.id = id;
            base.name = name;
        }
        public override void printEmployee()
        {
            Console.WriteLine(base.name+" welcome");
        }

        public override void printId()
        {
            Console.WriteLine(base.id + " welcome");
        }
    }
}

