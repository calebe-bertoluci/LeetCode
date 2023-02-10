Console.WriteLine("*** ROMAN TO INTEGER CONVERTER ***\n");

int thousand, hundred, ten, unit, i, j;
string romanThousand = "", romanHundred = "", romanTen = "", romanUnit = "";

Console.Write("Type an integer number: ");
int integerNumber = Convert.ToInt32(Console.ReadLine());

int hundredtenunit = 3;
var numericList = new List<int>(hundredtenunit);

for (i = 0; i <= 3; i++)
    numericList.Add(0);
for (i = 3; i >= 0; i--)
{
    j = integerNumber % 10;
    numericList[i] = j;
    integerNumber /= 10;
}
thousand = numericList[0];
thousand = (numericList[0] * 10) / 10;
hundred = numericList[1];
hundred = (numericList[1] * 10) / 10;
ten = numericList[2];
ten = (ten * 10) / 10;
unit = numericList[3];
unit = (unit * 10) / 10;

for (i = 0; i < thousand; i++)
{
    romanThousand = romanThousand + "M";
    if (thousand == 0)
        romanThousand = "";
}
for (i = 0; i < hundred; i++)
{
    romanHundred = romanHundred + "C";
    if (hundred == 4)
        romanHundred = "CD";
    if (romanHundred == "CCCCC")
        romanHundred = "D";
    if (hundred == 9)
        romanHundred = "CM";
    if (hundred == 0)
        romanHundred = "";
    if (hundred == 0)
        romanHundred = "";
}
for (i = 0; i < ten; i++)
{
    romanTen = romanTen + "X";
    if (ten == 4)
        romanTen = "XL";
    if (romanTen == "XXXXX")
        romanTen = "L";
    if (ten == 9)
        romanTen = "XC";
    if (ten == 0)
        romanTen = "";
}
for (i = 0; i < unit; i++)
{
    romanUnit = romanUnit + "I";
    if (unit == 4)
        romanUnit = "IV";
    if (romanUnit == "IIIII")
        romanUnit = "V";
    if (unit == 9)
        romanUnit = "IX";
    if (unit == 0)
        romanUnit = "";
}

Console.WriteLine("Your number in roman is: " + romanThousand + romanHundred + romanTen + romanUnit);