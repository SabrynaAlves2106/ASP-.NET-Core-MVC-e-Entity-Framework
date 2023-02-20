﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models.ViewModels
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament() { }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller sl)
        {
            Sellers.Add(sl);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(x => x.TotalSales(initial, final));
        }
    }
}