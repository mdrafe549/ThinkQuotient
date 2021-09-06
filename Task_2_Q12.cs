// Created By Sayed Md Rafe 
using System;
class sample
{
    public static void IFutureMethod()
    {
        Console.WriteLine("IFutureMethod method");
    }
    public void ZensarMethod(string v)
    {
        first();
        Console.WriteLine("ZensarMethod method");
    }

    public void first()
    {
        
    }

    public void ZensarMethod(int i)
    {
        Console.WriteLine(i);
        ZensarMethod();
    }

    private void ZensarMethod()
    {
        throw new NotImplementedException();
    }
}
class program
{
    public static void Main()
    {
        sample obj = new sample();
        obj.first();
        obj.ZensarMethod("Akkki");
        Console.Read();
    }
}





/*
    OUTPUT After rectifying errors:
    ZensarMethod method
 */




