using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.İnMemory
{
	public class İnMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		public İnMemoryCarDal()
		{
			_cars = new List<Car>
			{
			new Car{ Id=1, BrandId=1, ColorId=2, BrandName="mercedes", ModelYear="2015", Description="hatasız", DailyPrice=500},
			new Car{ Id=2, BrandId=1, ColorId=2, BrandName="BMW", ModelYear="2010", Description="hatalı", DailyPrice=300},
			new Car{ Id=3, BrandId=2, ColorId=1, BrandName="Toyota", ModelYear="2013", Description="hatalı", DailyPrice=400},
			new Car{ Id=4, BrandId=2, ColorId=1, BrandName="Opel", ModelYear="2016", Description="hatasız", DailyPrice=500},
			new Car{ Id=5, BrandId=1, ColorId=2, BrandName="Opel", ModelYear="2010", Description="hatasız", DailyPrice=300},
			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
			Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
			_cars.Remove(carToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int Id)
		{
			return _cars.Where(c => c.Id == c.Id).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;
		}
	}
}
