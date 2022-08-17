using System;

namespace LabExercise
{
    public class MyCalc
    {
      public static double Add(double op1, double op2)
    {
      return op1+op2;
    }

         public static double sub(double o1, double o2)
    {
      return o1-o2;
    }
    public static double mul(double m1,double m2)
    {
        return m1*m2;
    }
    public static int div(int n1 ,int n2 )
    {
         return n1/n2;
    }
    public static int pow(int p1 , int p2 )
    {
    int p3=p1;
     for(int i=1;i<p2;i++)
     {
        p3=p3*p1;
     }  
         return p3;
    }
   public static int power(int v1, int v2)
   {  
       int v3 = v1;
        int i = 1;
     while (i<v2)
     {
            v3 = v3*v1;
            i++;
     }
      return v3;
    
  
   }

   public static double po(double a1, double a2)
   {
    double po1;
    po1 = Math.Pow(a1,a2);
    return po1;
   }

    }
}
