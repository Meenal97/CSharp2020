﻿using CSharpBasic.Oops;
using CSharpBasic.TryCatch;
using System;
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

            AvoidTryCatchMissue try1 = new AvoidTryCatchMissue();
            try1.Divide();


        }
    }

 
}
