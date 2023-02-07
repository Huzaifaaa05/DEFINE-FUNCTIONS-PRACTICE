Console.Clear();
#nullable disable

// Student Feedback

static string studentFeedback(string name, string performance) {
    return $"{name} is doing {performance} in this class.";
}

Console.WriteLine(studentFeedback("Huzaifa", "Good"));

//  Heron's Formula

static double heronsFormula(int sideA, int sideB, int sideC) 
{
    int s = (sideA + sideB + sideC) / 2;
    return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
}

Console.WriteLine(heronsFormula(1, 2, 3));

// Analyze Number

static string analyzeNumber(int num) {
    string result;

    if (num > 0) {
        result = "positive";
    } else if (num < 0) {
        result = "negative";
    } else {
        result = "zero";
    }
    return result;
}

Console.WriteLine(analyzeNumber(0));


// Is Even?

static bool isEven(int num)
{
    return num % 2 == 0;
}

Console.WriteLine(isEven(8));

// Series Sum

static int seriesSum(int start, int stop, int step)
{
    int sum = 0;
    for (int i = start; i <= stop; i += step)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(seriesSum(20, 500, 10));