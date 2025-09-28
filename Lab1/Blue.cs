namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            answer = a * b > 0;

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here

            answer = Math.Abs(d - Math.Truncate(d)) >= 0.0001;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            answer = (b != 0) && (a % b == 0);

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            double max = d;
            if (Math.Abs(f) > Math.Abs(max)) max = f;
            if (Math.Abs(g) > Math.Abs(max)) max = g;
            answer = max;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x > -1 && x <= 0)
                answer = x + 1;
            if (x > 0)
                answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            answer = 2 * Math.Sqrt(circleS / Math.PI) <= Math.Sqrt(squareS);

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                    answer = -1;
            }
            else
            {
                if (f > 0)
                    answer = 1;
            }

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int coinsA = a / 2;
            int coinsB = b / 2;
            int coinsC = c / 2;

            if (coinsA >= 1 && coinsB >= 1 && coinsC >= 1)
            {
                int minTarget = Math.Max(coinsA, Math.Max(coinsB, coinsC));

                if (coinsC + 1 > minTarget)
                    minTarget = coinsC + 1;

                int maxTarget = Math.Min(a, Math.Min(b, c));

                if (minTarget <= maxTarget)
                    answer = true;
            }
            // end

            return answer;
        }
    }
}