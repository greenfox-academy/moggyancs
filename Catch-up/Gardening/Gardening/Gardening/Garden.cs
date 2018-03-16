﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gardening
{
    class Garden
    {
        List<Plant> MyGarden = new List<Plant>();

        public void Add(Plant plant)
        {
            MyGarden.Add(plant);
        }

        public void Irrigation (double WaterAmount)
        {
            Console.WriteLine($"Watering with {WaterAmount} \n");
            List<Plant> ToBeWatered = new List<Plant>();
            foreach (var plant in MyGarden)
            {
                if (plant.NeedsWater())
                {
                ToBeWatered.Add(plant);
                }
            }
            foreach (var plant in ToBeWatered)
            {
                plant.Watering(WaterAmount / ToBeWatered.Count);
            }
            ToBeWatered.RemoveAll(DoesItNeedWater);
        }

        public bool DoesItNeedWater(Plant plant)
        {
            return plant.NeedsWater();
        }

        public void ShowGarden()
        {
            foreach (var plant in MyGarden)
            {
                Console.WriteLine(plant.Status());
            }
                Console.WriteLine();
        }
    }
}
