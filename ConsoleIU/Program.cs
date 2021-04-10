using Business.Concrete;
using DataAccess.Concrete.İnMemory;
using System;

namespace ConsoleIU
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new İnMemoryCarDal() );
			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine(car.BrandName);
			}
		}
	}
}
