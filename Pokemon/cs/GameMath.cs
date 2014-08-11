/*
 * == Created ==
 * on: -unknown-
 * by: Eric Hopkins
 
 * == Modified ==
 * on: 8/10/2014
 * by: Eric Hopkins
 */
using System;

namespace Pokemon
{
	public static class GameMath
    {
        #region methods
        public static void gameLoadPopulate()
        {
            // call all of the different math functions.
            popErratic();
            popFast();
            popMediumFast();
            popMediumSlow();
            popSlow();
            popFluctuating();
        }
        #endregion


        #region privateMethods
        private static void popErratic()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i == 1)
				{
					int exp = 0;

					Model.Erratic [i - 1] = exp;
				}
				else if (i <= 50)
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					int exp = (((value) * ((100 - i))) / 50);

					Model.Erratic [i - 1] = exp;
				}
                else if (i > 50 && i < 68)
                {
                    int value = Convert.ToInt32(Math.Pow(i, 3));
                    int exp = (((value) * ((150 - i))) / 100);

                    Model.Erratic[i - 1] = exp;
                }
				else if (i >= 68 && i < 98)
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					int exp = (value * ((1911 - (10 * i)) / 3)) / 500;

					Model.Erratic [i - 1] = exp;
				}
				else
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					int exp = (value * (160 - i)) / 100;

					Model.Erratic [i - 1] = exp;
				}
			}
		}


		private static void popFast()
		{
			for (int i = 1; i <= 100; i++)
			{
				double computed = (4 * Math.Pow (i, 3)) / 5;
				int exp = Convert.ToInt32 (Math.Floor (computed));

				Model.Fast [i - 1] = exp;
			}
		}


		private static void popMediumFast()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i == 1)
				{
					Model.MediumFast [i - 1] = 0;
				}
				else
				{
					int exp = Convert.ToInt32 (Math.Pow (i, 3));

					Model.MediumFast [i - 1] = exp;
				}
			}
		}


		private static void popMediumSlow()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i == 1)
				{
					Model.MediumSlow [i - 1] = 0;
				}
				else
				{
					int squared = Convert.ToInt32 (Math.Pow (i, 2));
					int value = Convert.ToInt32 (Math.Pow (i, 3));

					double compute = ((6.0 / 5.0) * value) - (15.0 * squared) + (100 * i) - 140;
					int exp = Convert.ToInt32 (Math.Floor (compute));

					Model.MediumSlow [i - 1] = exp;
				}
			}
		}


		private static void popSlow()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i == 1) {
					Model.Slow [i - 1] = 0;
				}
				else
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					double compute = (5 * value) / 4;
					int exp = Convert.ToInt32 (compute);

					Model.Slow [i - 1] = exp;
				}
			}
		}


		private static void popFluctuating()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i == 0)
				{
					Model.Fluctuating [i - 1] = 0;
				}
				else if (i < 15)
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					double numerator = ((i + 1) / 3) + 24;
					double denominator = 50;
					double computed = value * (numerator / denominator);
					double modifier = (computed * 100) / 100;
					int exp = Convert.ToInt32 (Math.Floor (modifier));

					Model.Fluctuating [i - 1] = exp;
				}
				else if (i >= 15 && i < 36)
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					double computed = value * ((i + 14.0) / 50.0);
					double modifier = (computed * 100) / 100;
					int exp = Convert.ToInt32 (Math.Floor (modifier));

					Model.Fluctuating [i - 1] = exp;
				}
				else
				{
					int value = Convert.ToInt32 (Math.Pow (i, 3));
					double numerator = ((i / 2) + 32);
					double denominator = 50;
					double computed = value * (numerator / denominator);
					double modifier = (computed * 100) / 100;
					int exp = Convert.ToInt32 (Math.Floor (modifier));

					Model.Fluctuating [i - 1] = exp;
				}
			}
        }
        #endregion

    }
}

