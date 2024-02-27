using ClassLibrary;

int a = 16807;
int c = 0;
int m = 2147483647;
int seed = 12345;

int K = 30000;

RandomNumberGenerator rng = new RandomNumberGenerator(a, c, m, seed);
int[] randomValues = rng.GenerateRandomSequence(K);

StatisticsCalculator stats = new StatisticsCalculator();
double mean = stats.CalculateMean(randomValues);
double variance = stats.CalculateVariance(randomValues, mean);
double stdDeviation = Math.Sqrt(variance);

Console.WriteLine($"Mean: {mean}");
Console.WriteLine($"Variance: {variance}");
Console.WriteLine($"Standard Deviation: {stdDeviation}");