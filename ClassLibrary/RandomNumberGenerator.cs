namespace ClassLibrary
{
    public class RandomNumberGenerator
    {
        private int a; // Множник
        private int c; // Приріст
        private int m; // Модуль (2^31 - 1)
        private int seed; // Початкове значення

        public RandomNumberGenerator(int a, int c, int m, int seed)
        {
            this.a = a;
            this.c = c;
            this.m = m;
            this.seed = seed;
        }

        public int[] GenerateRandomSequence(int K)
        {
            int[] randomValues = new int[K];
            int x = seed;
            for (int i = 0; i < K; i++)
            {
                x = (a * x + c) % m;
                randomValues[i] = x;
            }
            return randomValues;
        }
    }
}