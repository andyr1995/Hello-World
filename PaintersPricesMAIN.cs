using System;

namespace PaintersPrices
{
	class PaintersPrices
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please state area of wall");
			double areaOfWall = Console.Read();
			areaOfWall = Console.Read();

			Console.WriteLine("Please state price of 5l paint can");
			double priceOf5lPaintCan = Console.Read();
			priceOf5lPaintCan  = Console.Read();

			Console.WriteLine("Please state hourly labor cost");
			double costOfHourlyLabor = Console.Read();
			costOfHourlyLabor = Console.Read();

			Console.WriteLine("Please state paint can coverage per square metre");
			double paintCanCoveragePerSquareMetre = Console.Read();
			paintCanCoveragePerSquareMetre = Console.Read();

			Console.WriteLine("Please state time taken for job");
			double timeTakenForJob = Console.Read();
			timeTakenForJob  = Console.Read();

			Console.WriteLine("The cost of this job is "+Math.Abs((paintCanCoveragePerSquareMetre/100)*areaOfWall)*priceOf5lPaintCan);
		}
	}
}