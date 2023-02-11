//Maximum value to convert is 3999
Console.WriteLine("*** ROMAN TO INTEGER CONVERTER ***\n");
Console.Write("Type a number in roman: ");

string romanNumber = Console.ReadLine();

char[] romanArray = new char[romanNumber.Length];
int[] decimalArray = new int[romanNumber.Length];

int i = 0, decimalNumber = 0;

foreach (char c in romanNumber)
{ 
    romanArray[i] = c;
    i++;
}

for (i = 0; i < romanNumber.Length; i++) 
{
    if (romanArray[i] == Convert.ToChar("I"))
        decimalArray[i] = 1;
    else if (romanArray[i] == Convert.ToChar("V"))
        decimalArray[i] = 5;
    else if (romanArray[i] == Convert.ToChar("X"))
        decimalArray[i] = 10;
    else if (romanArray[i] == Convert.ToChar("L"))
        decimalArray[i] = 50;
    else if (romanArray[i] == Convert.ToChar("C"))
        decimalArray[i] = 100;
    else if (romanArray[i] == Convert.ToChar("D"))
        decimalArray[i] = 500;
    else if (romanArray[i] == Convert.ToChar("M"))
        decimalArray[i] = 1000;
}

int j = 1;

for (i = 0; i < romanNumber.Length; i++) //Verify accidents
{
    if (j == romanNumber.Length) break;
    if (decimalArray[i] < decimalArray[j])
    {
        if (decimalArray[j] == 5)
        {
            decimalArray[j] = 4;
            decimalArray[i] = 0;
        }
        else if (decimalArray[j] == 10)
        {
            decimalArray[j] = 9;
            decimalArray[i] = 0;
        }
        else if (decimalArray[j] == 50)
        {
            decimalArray[j] = 40;
            decimalArray[i] = 0;
        }
        else if (decimalArray[j] == 100)
        {
            decimalArray[j] = 90;
            decimalArray[i] = 0;
        }
        else if (decimalArray[j] == 500)
        {
            decimalArray[j] = 400;
            decimalArray[i] = 0;
        }
        else if (decimalArray[j] == 1000)
        {
            decimalArray[j] = 900;
            decimalArray[i] = 0;
        }
    }
    j++;
}
int result = 0;

for (i = 0; i < romanNumber.Length; i++) //Array sum
    result += decimalArray[i];

Console.WriteLine("The roman number "+romanNumber+" to integer, is: " + result);