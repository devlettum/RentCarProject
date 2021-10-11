﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice<0 && car.Description.Length>2)
            {
                _carDal.Add(car);
                Console.WriteLine("Car Added : " + car.Description);
            }
            else
            {
                Console.WriteLine("Araba eklenemedi...");
            }
            
        }

        public void Delete(Car car)
        {
           _carDal.Delete(car);
        }

        public Car Get(int carId)
        {
            return null;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}