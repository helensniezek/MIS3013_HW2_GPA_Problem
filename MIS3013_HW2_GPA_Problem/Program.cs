// MIS 3013 001 HW2 Grade Problem


double overGPADbl = 0;

string outMesStr;
string inputMesStr;

// Accounting, Marketing, Economics and MIS courses
// A, B, C, D, F
// accounting
int accCreditHoursInt = 3;
int accPointValueDbl = -1;
char accletterGradeCh = 'E';
double accGradeDbl=-1;
outMesStr = "Please input the grade of accounting:";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
accGradeDbl=Convert.ToDouble(inputMesStr);
if(accGradeDbl>=90)
{
    accletterGradeCh = 'A';
    accPointValueDbl = 4;
}
else if (accGradeDbl>=80)
{
    accletterGradeCh = 'B';
    accPointValueDbl = 3;
}
else if (accGradeDbl>=70)
{
    accletterGradeCh = 'C';
    accPointValueDbl = 2;
}
else if (accGradeDbl>=60)
{
    accletterGradeCh = 'E';
    accPointValueDbl = 1;
}
else
{
    accletterGradeCh = 'F';
    accPointValueDbl = 0;
}

// Marketing
int markCreditHoursInt = 3;
int markPointValueDbl = -1;
char markletterGradeCh = 'E';
double markGradeDbl = -1;
outMesStr = "Please input the grade of marketing: ";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
markGradeDbl = Convert.ToDouble(inputMesStr);
if (markGradeDbl >= 90)
{
    markletterGradeCh = 'A';
    markPointValueDbl = 4;
}
else if (markGradeDbl >= 80)
{
    markletterGradeCh = 'B';
    markPointValueDbl = 3;
}
else if (markGradeDbl >= 70)
{
    markletterGradeCh = 'C';
    markPointValueDbl = 2;
}
else if (markGradeDbl >= 60)
{
    markletterGradeCh = 'E';
    markPointValueDbl = 1;
}
else
{
    markletterGradeCh = 'F';
    markPointValueDbl = 0;
}

// Economics
int econCreditHoursInt = 3;
int econPointValueDbl = -1;
char econletterGradeCh = 'E';
double econGradeDbl = -1;
outMesStr = "Please input the grade of economics:";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
econGradeDbl = Convert.ToDouble(inputMesStr);
if (econGradeDbl >= 90)
{
    econletterGradeCh = 'A';
    econPointValueDbl = 4;
}
else if (econGradeDbl >= 80)
{
    econletterGradeCh = 'B';
    econPointValueDbl = 3;
}
else if (econGradeDbl >= 70)
{
    econletterGradeCh = 'C';
    econPointValueDbl = 2;
}
else if (econGradeDbl >= 60)
{
    econletterGradeCh = 'E';
    econPointValueDbl = 1;
}
else
{
    econletterGradeCh = 'F';
    econPointValueDbl = 0;
}

// MIS
int misCreditHoursInt = 3;
int misPointValueDbl = -1;
char misletterGradeCh = 'E';
double misGradeDbl = -1;
outMesStr = "Please input the grade of MIS:";
Console.WriteLine(outMesStr);
inputMesStr = Console.ReadLine();
misGradeDbl = Convert.ToDouble(inputMesStr);
if (misGradeDbl >= 90)
{
    misletterGradeCh = 'A';
    misPointValueDbl = 4;
}
else if (misGradeDbl >= 80)
{
    misletterGradeCh = 'B';
    misPointValueDbl = 3;
}
else if (misGradeDbl >= 70)
{
    misletterGradeCh = 'C';
    misPointValueDbl = 2;
}
else if (misGradeDbl >= 60)
{
    misletterGradeCh = 'E';
    misPointValueDbl = 1;
}
else
{
    misletterGradeCh = 'F';
    misPointValueDbl = 0;
}

// overall GPA
overGPADbl = (accPointValueDbl*accCreditHoursInt+markPointValueDbl*markCreditHoursInt+econPointValueDbl*econCreditHoursInt
    +misPointValueDbl*misCreditHoursInt)*1.0 / (accCreditHoursInt+markCreditHoursInt+econCreditHoursInt+misCreditHoursInt);

outMesStr = "The letter grades:";
Console.WriteLine("\n");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Accounting: {accletterGradeCh}");
Console.WriteLine( outMesStr );

outMesStr = String.Format($"Letter grade of Marketing: {markletterGradeCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of Economics: {econletterGradeCh}");
Console.WriteLine(outMesStr);

outMesStr = String.Format($"Letter grade of MIS: {misletterGradeCh}");
Console.WriteLine(outMesStr);

// overall GPA
outMesStr = String.Format($"Overall GPA: {overGPADbl:F2}");
Console.WriteLine();
Console.WriteLine(outMesStr);

Console.ReadLine();


