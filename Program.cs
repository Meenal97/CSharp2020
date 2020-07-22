﻿using AssemblyOne;
using AssemblyTwo;
using CSharpBasic.Oops;
using CSharpBasic.TryCatch;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Threading;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Polymorphism
            BaseClass b = new DerivedClass();
            b.print();
            #endregion

            #region MethodHiding
            BaseClass2 b2 = new DerivedClass2();
            b2.print();
            #endregion

            #region MethodOverloading
            BaseClass3 b3 = new DerivedClass3();
            b3.print();
            #endregion

            #region TryCatchFinallyBasic
            TryCatchFinally t = new TryCatchFinally();
            t.ReaderFromFile();
            #endregion

            #region InterfaceBasic1
            classA a = new classA();
            a.details();
            a.print();
            #endregion

            #region InterTypcasting, Interface reference varaible
            classAB ab = new classAB();
            ((IA)ab).print();
            ((IB)ab).print();

            IA a1 = new classAB();
            a1.print();

            IB b1 = new classAB();
            b1.print();
            #endregion

            #region Abstract Classes
            studentclass s2 = new studentclass();
            s2.details();
            s2.print();

            abstractClass a3 = new studentclass();
            a3.print();
            a3.details();
            #endregion

            #region Constrcutor
            Name name = new Name();
            name.printName();

            Name name2 = new Name("Meenal");
            name2.printName();
            #endregion

            #region GetterSetter
            GetterSetter g = new GetterSetter();
            Console.WriteLine("Pass Marks " + g.GetPassMarks());
            g.SetName("Meenal");
            Console.WriteLine("Get Name {0} ", g.GetName());
            g.SetID(100);
            Console.WriteLine("Set ID {0}", g.GetID());
            #endregion

            #region Properities
            Console.WriteLine("-------------------------------------------------");
            PropertiesInCsharp p = new PropertiesInCsharp();
            p.Id = 100;
            Console.WriteLine("ID {0}", p.Id);
            p.Name = "Meenal";
            Console.WriteLine("Name {0}", p.Name);
            Console.WriteLine("PassMarks {0} ", p.PassMarks);
            #endregion

            #region AvoidTryCatch
            AvoidTryCatchMissue try1 = new AvoidTryCatchMissue();
            try1.Divide();
            #endregion

            #region WhyEnums
            WhyEnums[] w = new WhyEnums[3];
            w[0] = new WhyEnums
            {
                Name = "Mark",
                Gender = 1
            };

            w[1] = new WhyEnums
            {
                Name = "mary",
                Gender = 2
            };

            w[2] = new WhyEnums
            {
                Name = "Sam",
                Gender = 0
            };


            foreach(WhyEnums Customer in w)
            {
                
                Console.WriteLine("Name = {0} &&  Gender {1}" , Customer.Name, getGender(Customer.Gender) );
            }
            #endregion

            #region Line
            Console.WriteLine("____________________________________________________________________________________________________");
            #endregion

            #region Enum
            Enums[] e = new Enums[3];
            e[0] = new Enums
            {
                Name = "Mark",
                gender = Gender.Male
            };

            e[1] = new Enums
            {
                Name = "mary",
                gender = Gender.Female
            };

            e[2] = new Enums
            {
                Name = "Sam",
                gender = Gender.Unknonw
            };


            foreach (Enums Customer in e)
            {

                Console.WriteLine("Name = {0} &&  Gender {1}", Customer.Name, getGenderEnum(Customer.gender));
            }
            #endregion

            #region Access Modifier
            AccessModifiersclass2 a2 = new AccessModifiersclass2();
            a2.PrintID();
            a2.p();
            a2.first_Name = "Meenal";
            Console.WriteLine("Internal attribute : {0} ", a2.first_Name);
            #endregion

            #region AssemblyAccessSpecifiers
            AssemblyOneClassII aII = new AssemblyOneClassII();
            aII.SampleMethod();

            AssemblyTwoClassOne atwo = new AssemblyTwoClassOne();
            atwo.SampleMethod();
            #endregion

            #region Base class constructer is called before drived class constrctor
            DerivedClassOne done = new DerivedClassOne();
            #endregion

            #region Polymorphism 2
            EmployeeOne[] emp = new EmployeeOne[3];
            emp[0] = new EmployeeOne();
            emp[1] = new PartTimeEmployee();
            emp[2] = new FullTimeEmployee();

            foreach (EmployeeOne employee in emp)
            {
                employee._firstName = "Meenal";
                employee._lastName = "Preet";
            }


            foreach (EmployeeOne employee in emp)
            {
                Console.WriteLine(employee.PrintFullName());
            }
            #endregion

            #region Attributes
            Attributess a5 = new Attributess();
            Attributess a6 = new Attributess();
            int cal = a5.Calculator(new List<int>() { 12, 56, 88 });
            int cal2 = a6.Calculator(new List<int>() {35,67,77 });
            Console.WriteLine("Calculator {0}", cal);
            #endregion

            #region Reflection
            CustomerClass cOne = new CustomerClass();
            Type T = cOne.GetType();
         //   Type T = typeof(CustomerClass);
         //   Type T = Type.GetType("CSharpBasic.CustomerClass");
            Console.WriteLine("FullName {0} ", T.FullName);
            Console.WriteLine("Just a Name {0} ", T.Name);
            Console.WriteLine("Namespace {0} ", T.Namespace);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Properties-------------------------------------------------------------------------------------");
            PropertyInfo[] properties = T.GetProperties();

            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("Proprty Name {0} , Return Type {1}", property.Name, property.PropertyType.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Methods-------------------------------------------------------------------------------------");
            MethodInfo[] Methods = T.GetMethods();

            foreach (MethodInfo method in Methods)
            {
                Console.WriteLine(method.ReturnType.Name + " "+ method.Name  + " " + method.GetParameters());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Constructor-------------------------------------------------------------------------------------");
            ConstructorInfo[] Constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in Constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            #endregion

            #region Generics
            bool Equal = Generics.AreEqual<int>(2, 6);
            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not eqaul");
            }
            #endregion

            ToStringMethod str = new ToStringMethod();
            str.FirstName = "ABC";
            str.LastName = "CS";

            Console.WriteLine(str.ToString());

        }

        #region WhyEnumFunction
        public static string getGender(int gender)
        {
            switch(gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
        #endregion


        #region EnumFunction
        public static string getGenderEnum(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknonw:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }
        #endregion

    }


}
