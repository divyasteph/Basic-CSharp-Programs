//Armstrong Number
using System;  
  public class ArmstrongExample  
   {  
     public static void Main(string[] args)  
      {  
       int  n,r,sum=0,temp;            
       n= 345;     
       temp=n;      
       while(n>0)      
       {      
        r=n%10;      
        sum=sum+(r*r*r);      
        n=n/10;      
       }      
       if(temp==sum)      
        Console.Write("Armstrong Number.");      
       else      
        Console.Write("Not Armstrong Number.");      
      }  
  }  

//Prime Number
using System;
namespace Demo {
   class MyApplication {
      public static void Main() {
         int n = 5, a = 0;
         for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine("{0} is a Prime Number", n);
         } else {
            Console.WriteLine("Not a Prime Number");
         }
         Console.ReadLine();
      }
   }
}

//Pallindrome
using System;  
  public class PalindromeExample  
   {  
     public static void Main(string[] args)  
      {  
          int n,r,sum=0,temp;    
          n = 676; 
          temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }      
          if(temp==sum)      
           Console.Write("Number is Palindrome.");      
          else      
           Console.Write("Number is not Palindrome");     
    }  
  }  
