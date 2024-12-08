using CourseProject.BLL.Interfaces;
using CourseProject.Core.Entities;
using CourseProject.DAL.Repositories;
using System;
using System.Collections.Generic;

namespace CourseProject.BLL.Services
{
    public class BoilerService : IBoilerService
    {
        private readonly IRepository<Boiler> _repository;

        public BoilerService(IRepository<Boiler> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Boiler> GetAllBoilers()
        {
            return _repository.GetAll();
        }

        public Boiler GetBoilerById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void AddBoiler(Boiler boiler)
        {
            _repository.Add(boiler);
        }

        public void UpdateBoiler(Boiler boiler)
        {
            _repository.Update(boiler);
        }

        public void DeleteBoiler(Guid id)
        {
            _repository.Delete(id);
        }
    }
}