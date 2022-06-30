using System;

namespace BasicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //No1
            
            int x; int y;
            int min; int max;
            Console.WriteLine("Enter 1st integer: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a 2nd integer: ");
            y = int.Parse(Console.ReadLine());

            //using ternary operator
            max = (x > y) ? x : y;
            min = (x < y) ? x : y;

            if (x!=y){
                Console.WriteLine("The minimum number is: " + min);
                Console.WriteLine("The maximum number is: " + max + "\n");
            }         
            else
            {
                Console.WriteLine("The numbers are both equal therefore there are 0 numbers in between them that are divisible by 5 and results to zero.");
            }

            int arrayspaces = 0; 
            for (int i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    arrayspaces++;
                }
            }

            int counter = 0; int[] arr = new int[arrayspaces]; 
            for (int i = min; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    arr[counter] = i;
                    counter++;
                }
            }
                        
            Console.WriteLine("[{0}]", string.Join(", ", arr));            
            Console.WriteLine("There are {0} numbers that are divisible by 5 and results to zero between the min and max number.", counter);
            Console.ReadLine();


           //NO2
           Console.WriteLine("please enter your number:");
           int n = int.parse(Console.Readline());
           if (n == 0)
           {
             Console.WriteLine("Invalid input!");
             return;
           }
           else if ( n == 1)
           {
            Console.WriteLine("0");
            return;
           }
           intx1 = 0;
           intx2 = 1;
           Console.Write("{0} {1}" , x1,x2);
           
           for (int i = 2; i < n; i++)
           {
             int x3 = x1 + x2;
             Console.Write("{0}", x3);
             x1 = x2;
             x2 = x3;
           }
             Console.WriteLine();
             
             //No3
             Console.WriteLine("Please write 5 numbers:");
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());
 
        if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
        {
            Console.WriteLine("The biggest number is: {0}", a);
            return;
        }
        if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
        {
            Console.WriteLine("The biggest number is: {0}", b);
            return;
        }
        if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
        {
            Console.WriteLine("The biggest number is: {0}", c);
            return;
        }
        if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
        {
            Console.WriteLine("The biggest number is: {0}", d);
            return;
        }
        if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
        {
            Console.WriteLine("The biggest number is: {0}", e);
            return;


            //no4
            int a,b,c;
            double d x1,x2;
            Console.Write("\n\n");
            Console Write("calculate the root of Quadratic Equation : \n");
            Console.Write("---------------------");
            Console.Write("\n\n");

            Console.WriteLine("Input the value of a :");
            a = Convert.Toint32("Console.ReadLine()");
            Console.WriteLine("Input the value of b :");
            b = Convert.Toint32("Console.ReadLine()");
            Console.WriteLine("Input the value of c :");
            c = convert.Toint32("Console.ReadLine()");\
            
            d=b*b-4*a*c;
            if (d==0)
            {
              Console.Write("Both root are equal :");
              x1=-b/(2.0*a);
              x2=x1;
              Console.Write(" First Root Root1={0}\n",x1);
              Console.Write(" Second Root Root2={0}\n",x2);
            }
            else if(d>0)
            {
             Console.Write("Both root are real and diff-2\n");
             
             x1=(-b+Math.Sqrt(d))/(2*a);
             x1=(-b-Math.Sqrt(d))/(2*a);

               Console.Write(" First Root Root1={0}\n",x1);
              Console.Write(" Second Root Root2={0}\n",x2);
            }

            //No5
             Console.WriteLine("Please write a number between 1 and 9: ");
        int a = int.Parse(Console.ReadLine());
 
        switch (a)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("The BONUS score is: " + (a * 10));
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("The BONUS score is: " + (a * 100));
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("The BONUS score is: " + (a*1000));
                break;
            default:
                Console.WriteLine("Invalid Score!");
                break;

                //No6
                 Console.WriteLine("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());
 
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 7 ==0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        //No8
         Console.WriteLine("Please enter your number:");
        int n = int.Parse(Console.ReadLine());
 
        if (n == 0)
        {
            Console.WriteLine("Invalid input!");
            return;//we use return to terminate the program if "n" is 0
        }
        else if (n == 1)
        {
            Console.WriteLine(0);
            return;//we use return to terminate the program if "n" is 1
        }
 
        int x1 = 0;
        int x2 = 1;
        Console.Write("{0} {1} ", x1, x2);//we print the first 2 numbers of the Fibonacci sequence
 
        for (int i = 2; i < n; i++)//we do the calculation for the numbers ABOVE 2
        {
            int x3 = x1 + x2;
            Console.Write("{0} ", x3);//we use Console.Write INSTEAD OF Console.WriteLine - to glue the above Console.Write - the start of the Fibonacci
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine();

        //No11
         int[] first = { 1, 2, 3, 4, 5 };
        int[] second = { 1, 2, 3, 4, 5 };
 
        if (checkEquality(first, second)) {
            Console.WriteLine("Both arrays are equal");
        }
        else {
            Console.WriteLine("Both arrays are not equal");

            //No12
        int pos=0, bestpos=0, bestlen = 0;
        int len = 1;
        int[] vargu = { 2, 2, 3, 4, 5, 5, 5, 6, 9, 9, 9, 9 };

        for(int i = 0; i < vargu.Length-1; i++)
        {
            if (vargu[i] == vargu[i++])
            {
                len++;
                if (len > bestlen)
                {
                    bestlen = len;
                    bestpos = pos;
                }
            }
            else
            {
                len = 1;
                pos = i++;
            }
        }

        for(int k = bestpos; k <= bestlen; k++)
        {
            Console.Write("{0}", vargu[k]);
        }
        Console.ReadLine();

        //No13
        int max_freq = 0
       int ans = -1
       for (i = 0 to n-1)
       {
        int curr_freq = 1
        for (j = i+1 to n-1)
            if (A[j] == A[i])
                curr_freq = curr_freq + 1
        
        if (max_freq < curr_freq)
        {
            max_freq = curr_freq
            ans = A[i]
        }
       else if (max_freq == curr_freq)
            ans = min(ans, A[i])
        }
       return ans
        
        //No14
        int main()  
{  
    int num, bin = 0, rem = 0, place = 1;  
  
    printf("Enter a decimal number\n");  
    scanf("%d", &num);  
  
    printf("\nBinary equivalent of %d is ", num);  
    while(num)  
    {  
        rem   = num % 2;  
        num   = num / 2;  
        bin   = bin + (rem * place);  
        place = place * 10;  
    }  
    printf("%d\n", bin);  
  
    return 0;  
     //No15
      main() {
  int n, bin;
  printf("Enter a decimal number: ");
  scanf("%d", &n);
  bin = convert(n);
  printf("%d in decimal =  %lld in binary", n, bin);
  return 0;
}

long long convert(int n) {
  long long bin = 0;
  int rem, i = 1;

  while (n!=0) {
    rem = n % 2;
    n /= 2;
    bin += rem * i;
    i *= 10;
  }

  return bin;
}
    //No16
    int main()
{
    long decimalnum, quotient, remainder;
    int i, j = 0;
    char hexadecimalnum[100];
 
    printf("Enter decimal number: ");
    scanf("%ld", &decimalnum);
 
    quotient = decimalnum;
 
    while (quotient != 0)
    {
        remainder = quotient % 16;
        if (remainder < 10)
            hexadecimalnum[j++] = 48 + remainder;
        else
            hexadecimalnum[j++] = 55 + remainder;
        quotient = quotient / 16;
    }
 
    // display integer into character
    for (i = j; i >= 0; i--)
            printf("%c", hexadecimalnum[i]);
    return 0;

     //no17
      nt hexadecimalToDecimal(string hexVal)
{
    int len = hexVal.size();
 
    
    int base = 1;
 
    int dec_val = 0;
 
  
    
    for (int i = len - 1; i >= 0; i--) {
        
        if (hexVal[i] >= '0' && hexVal[i] <= '9') {
            dec_val += (int(hexVal[i]) - 48) * base;
 
          
            base = base * 16;
        }

        
        else if (hexVal[i] >= 'A' && hexVal[i] <= 'F') {
            dec_val += (int(hexVal[i]) - 55) * base;
 
            
            base = base * 16;
        }
    }
    return dec_val;

     //No19
      
int main()
{
    long int binaryval, hexadecimalval = 0, i = 1, remainder;
 
    printf("Enter the binary number: ");
    scanf("%ld", &binaryval);
    while (binaryval != 0)
    {
        remainder = binaryval % 10;
        hexadecimalval = hexadecimalval + remainder * i;
        i = i * 2;
        binaryval = binaryval / 10;
    }
    printf("Equivalent hexadecimal value: %lX", hexadecimalval);
    return 0;






             



        }
    }
}
