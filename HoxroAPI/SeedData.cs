using Entity.Models;
using Microsoft.Extensions.DependencyInjection;
using Repositorys.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoxroAPI
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<HoxroDbContext>();
            context.Database.EnsureCreated();
            if (!context.Items.Any())
            {
                context.Items.Add(entity: new Item() { Name = "Green Thunder" });
                context.Items.Add(entity: new Item() { Name = "Berry Pomegranate" });
                context.Items.Add(entity: new Item() { Name = "Betty Crocker" });
                context.Items.Add(entity: new Item() { Name = "Pizza Crust Mix" });
                context.Items.Add(entity: new Item() { Name = "Pizza Crust Mix" });
                context.Items.Add(entity: new Item() { Name = "Easy Melt Cheese Loaf" });
                context.Items.Add(entity: new Item() { Name = "Pickled Jalapeño Nacho Slices" });
                context.Items.Add(entity: new Item() { Name = "Pear Halves" });
                context.Items.Add(entity: new Item() { Name = "Pineapple Slices in 100% Pineapple Juice" });
                context.Items.Add(entity: new Item() { Name = "Four Cheese" });
                context.Items.Add(entity: new Item() { Name = "Creamy Tomato" });
                context.Items.Add(entity: new Item() { Name = "Spring Water" });
                context.Items.Add(entity: new Item() { Name = "Refried Beans Traditional" });
                context.Items.Add(entity: new Item() { Name = "Blackeye Peas seasoned with bacon" });
                context.Items.Add(entity: new Item() { Name = "Nesquik Chocolate Syrup" });
                context.Items.Add(entity: new Item() { Name = "Italian Dressing" });
                context.Items.Add(entity: new Item() { Name = "Baking Powder" });
                context.Items.Add(entity: new Item() { Name = "Diced Green Chiles mild" });
                context.Items.Add(entity: new Item() { Name = "Crushed Tomatoes" });
                context.Items.Add(entity: new Item() { Name = "Tomato Ketchup" });
                context.Items.Add(entity: new Item() { Name = "Asparagus Spears extra long hand selected" });
                context.Items.Add(entity: new Item() { Name = "Honey Mustard" });
                context.Items.Add(entity: new Item() { Name = "Grated Parmesan Cheese" });
                context.Items.Add(entity: new Item() { Name = "Real Mayo" });
                context.Items.Add(entity: new Item() { Name = "Ranch Dressing and Dip" });
                context.Items.Add(entity: new Item() { Name = "Strawberry Fruit Spread" });
                context.Items.Add(entity: new Item() { Name = "Sweet 'n Smoky sauce for BBQ & Dipping" });
                context.Items.Add(entity: new Item() { Name = "Barbeque Sauce Carolina" });
                context.Items.Add(entity: new Item() { Name = "Classic Catalina Dressing" });
                context.Items.Add(entity: new Item() { Name = "Original Syrup" });
                context.Items.Add(entity: new Item() { Name = "Natural Honey Cornbread and Muffin mix" });
                context.Items.Add(entity: new Item() { Name = "Squeezable Chipotle" });
                context.Items.Add(entity: new Item() { Name = "Buttery Spray" });
                context.Items.Add(entity: new Item() { Name = "Browning & Seasoning Sauce" });
                context.Items.Add(entity: new Item() { Name = "Maraschino Cherries" });
                context.Items.Add(entity: new Item() { Name = "Spreadable Butter with Canola Oil" });
                context.SaveChanges();
            }

            if (!context.Shoppings.Any()) {
                context.Shoppings.Add(entity:new Shopping() { Name="Defualt" });
                context.SaveChanges();
            }
        }
    }
}
