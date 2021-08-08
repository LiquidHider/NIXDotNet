using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using App.Domain.Core;

namespace App.Infrastructure.Data
{
    public class ApplicationContext
    {
        public List<Cabriolet> Cabriolets = new List<Cabriolet>();
        public List<Coupe> Coupe = new List<Coupe>();
        public List<Hatchback> Hatchbacks = new List<Hatchback>();
        public List<Limousine> Limousines = new List<Limousine>();
        public List<Minivan> Minivans = new List<Minivan>();
        public List<Roadster> Roadsters = new List<Roadster>();
        public List<Sedan> Sedans = new List<Sedan>();
        public List<SUV> SUVs = new List<SUV>();

        public List<BreakSystem> BreakSystems = new List<BreakSystem>();
        public List<Bumper> Bumpers = new List<Bumper>();
        public List<Engine> Engines = new List<Engine>();
        public List<Headlights> Headlights = new List<Headlights>();
        public List<RearViewMirrors> RearViewMirrors = new List<RearViewMirrors>();
        public List<Seats> Seats = new List<Seats>();
        public List<SideSkirts> SideSkirts = new List<SideSkirts>();
        public List<Transmission> Transmissions = new List<Transmission>();
        public List<Wheels> Wheels = new List<Wheels>();
        public List<Window> Windows = new List<Window>();

        public List<AcousticSystem> AcousticSystems = new List<AcousticSystem>();
        public List<AntiSlipChains> AntiSlipChains = new List<AntiSlipChains>();
        public List<BabySeat> BabySeats = new List<BabySeat>();
        public List<CruiseControl> CruiseControls = new List<CruiseControl>();
        public List<Extinguisher> Extinguishers = new List<Extinguisher>();
        public List<RearViewCamera> RearViewCameras = new List<RearViewCamera>();
        public List<SeatBelts> SeatBelts = new List<SeatBelts>();
        public List<Spoiler> Spoilers = new List<Spoiler>();
        public List<Wiper> Wipers = new List<Wiper>();

        public List<Customer> Customers = new List<Customer>();
        public List<Moderator> Moderators = new List<Moderator>();
        public List<Administrator> Administrators = new List<Administrator>();

        public string DataPath;

        public ApplicationContext() 
        {
            DataPath = string.Concat(AppDomain.CurrentDomain.BaseDirectory, $"AllData.txt");
        }
        public void SaveChanges()
        {
            using (StreamWriter sw = new StreamWriter(DataPath))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };
                sw.WriteLine(JsonSerializer.Serialize(Customers, options));
                sw.Close();
            }
        }
    }
}
