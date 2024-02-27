namespace ClassLibrary
{
    public class RandomNumberGenerator
    {
        private int a;
        private int c;
        private int m;
        private int seed;

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