namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int a1 = Convert.ToInt32(c == 0 && b == 0 && a == 0);
            int a2 = Convert.ToInt32(c < 0 && b < 0 && a < 0);
            int a3 = Convert.ToInt32(c > 0 && b > 0 && a > 0);

            answer = Convert.ToBoolean(Math.Max(Math.Max(a1, a2), a3));

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here
            
            // end

            return answer;
        }
    }
}
