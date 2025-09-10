namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here

            if (a * b > 0 && b * c > 0)
            {
                answer = true;
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            if (b != 0 && a % b == 0 || a != 0 && b % a == 0)
            { 
                answer = true;
            }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            if (a * a == b || b * b == a || a * a * a == b || b * b * b == a)
            {
                answer = true;
            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            var dis = f * f - 4 * d * g;
            answer = dis;

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            if (x <= -1)
            {
                answer = 1;
            }
            else if (x > 1)
            {
                answer = -1;
            } else
            {
                answer = -x;
            }

                // end

                return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            var r = circleS / Math.PI;
            var d = squareS / 2;
            if (d < r)
            {
                answer = true;
            }

            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here

            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            // code here

            int avr = (int)Math.Ceiling((double)pupils / 7);
            Console.WriteLine(avr);
            int sum = avr * salary + 5 * pupils;
            bool p1 = sum <= bank;
            bool p2 = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;

            if (p1 && !p2)
            {
                answer = true;
            }
            
            // end

            return answer;
        }
    }
}