//1.start

//2.Define function f(x)

//3.Choose initial guesses x1 and x2 such that f(x1)f(x2) < 0

//4.Choose Number Of Itrations (itl).

//5. Calculate the mid-point (m) = (x1 + x2) / 2

//6.Calculate fx3.

//  a. if fx3 < 0 then x1 = m 
//  b. if fx3> 0 then x2 = m
//7.Display (fx3) as root.

//9.Stop



double fx1, fx2, fx3;
double x1, x2;
double itre, m;
//no tolerance declared

while (true)
{


    Console.Write("Enter Value for X1 :");
    x1 = double.Parse(Console.ReadLine());//use float.Parse instead
    fx1 = Math.Pow(2, x1) - 8 * x1;

    Console.Write("Enter Value for X2 :");
    x2 = double.Parse(Console.ReadLine());
    fx2 = Math.Pow(2, x2) - 8 * x2;
    //no check for fx1*fx2 < 0
    Console.Write("Number Of Itrations(tolerance) = ");
    itre = double.Parse(Console.ReadLine());

    if (fx1 * fx2 < 0)
    {
        break;
    }
    Console.WriteLine("enter other values of X1 and X2");


}


while (true)
{


     m = (x1 + x2) / 2;

    fx3 = Math.Pow(2, m) - 8 * m;

    if (Math.Abs(fx3) < itre || fx3 == 0)
    {
        Console.WriteLine("mid point is {0}, and the root is {1}.", m, fx3);
        break;
    }
    if ((fx3 < 0 && fx1 < 0) || (fx3 > 0 && fx1 > 0))
    {
        x1 = m;
    }
    else
    {
        x2 = m;
    }

}
