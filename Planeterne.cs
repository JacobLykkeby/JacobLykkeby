using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace Planeterne
{
    public class Planets
    {
        private string Name;
        private double Mass;
        private double Diameter;
        private double Density;
        private double Gravity;
        private double RotationPeriod;
        private double Lenghtofday;
        private double Distancefromsun;
        private double Orbitaldays;
        private double Orbitalvelocity;
        private double Meantempature;
        private double Numberofmoons;
        private bool Ringsystem;


        public string name
        {
            get { return Name; }
            set { Name = value; }

        }
        public double mass
        {
            get { return Mass; }
            set { Mass = value; }

        }

        public double diameter
        {
            get { return Diameter; }
            set { Diameter = value; }
        }

        public double density
        {
            get { return Density; }
            set { Density = value; }

        }

        public double gravity
        {
            get { return Gravity; }
            set { Gravity = value; }
        }

        public double rotationperiod
        {
            get { return RotationPeriod; }
            set { RotationPeriod = value; }

        }

        public double lenghtofday
        {
            get { return Lenghtofday; }
            set { Lenghtofday = value; }
        }

        public double distancefromsun
        {
            get { return Distancefromsun; }
            set { Distancefromsun = value; }
        }

        public double orbitaldays
        {
            get { return Orbitaldays; }
            set { Orbitaldays = value; }
        }

        public double orbitalvelocity
        {
            get { return Orbitalvelocity; }
            set { Orbitalvelocity = value; }
        }

        public double meantempature
        {
            get { return Meantempature; }
            set { Meantempature = value; }
        }

        public double numberofmoons
        {
            get { return Numberofmoons; }
            set { Numberofmoons = value; }
        }

        public bool ringsystem
        {
            get { return Ringsystem; }
            set { Ringsystem = value; }
        }


        private Planets(double Mass, double Diameter, double Density, double Gravity, double RotationPeriod, double Lenghtofday, double Distancefromsun, double Orbitaldays, double orbitalvelocity, double Meantemparature, double Numberofmoons, bool Ringsystem)
        {
            this.Mass = mass;
            this.Diameter = diameter;
            this.Density = density;
            this.Gravity = gravity;
            this.RotationPeriod = rotationperiod;
            this.Lenghtofday = lenghtofday;
            this.Distancefromsun = distancefromsun;
            this.Orbitaldays = orbitaldays;
            this.Orbitalvelocity = orbitalvelocity;
            this.Meantempature = meantempature;
            this.Numberofmoons = numberofmoons;
            this.Ringsystem = ringsystem;
        }


    }
        


    class Program
    {
        static void Main(string[] args)
        {

            Planets Mercury = new Planets();
            {
                Mercury.name = "Mercury";
                Mercury.mass = 0.330;
                Mercury.diameter = 4879;
                Mercury.density = 5427;
                Mercury.gravity = 3.7;
                Mercury.rotationperiod = 1407.6;
                Mercury.lenghtofday = 4222.6;
                Mercury.distancefromsun = 57.9;
                Mercury.orbitaldays = 88.0;
                Mercury.orbitalvelocity = 47.4;
                Mercury.meantempature = 167;
                Mercury.numberofmoons = 0;
                Mercury.ringsystem = false;
            }

            Planets Venus = new Planets();
            {
                Venus.name = "Venus";
                Venus.mass = 4.87;
                Venus.diameter = 12104;
                Venus.density = 5243;
                Venus.gravity = 8.9;
                Venus.rotationperiod = -5832.5;
                Venus.lenghtofday = 2802.0;
                Venus.distancefromsun = 108.2;
                Venus.orbitaldays = 224.7;
                Venus.orbitalvelocity = 35.0;
                Venus.meantempature = 464;
                Venus.numberofmoons = 0;
                Venus.ringsystem = false;
            }

            Planets Earth = new Planets();
            {
                Earth.name = "Earth";
                Earth.mass = 5.97;
                Earth.diameter = 12756;
                Earth.Density = 5514;
                Earth.Gravity = 9.8;
                Earth.Rotationperiod = 23.9;
                Earth.Lengthofday = 24.7;
                Earth.Distancefromsun = 149.6;
                Earth.Orbitalperiod = 365.2;
                Earth.Orbitalvelocity = 29.8;
                Earth.Meantemperature = 15;
                Earth.Numberofmoons = 1;
                Earth.Ringsystem = false;
            }

            Planets Mars = new Planets();
            {
                Mars.Name = "Mars";
                Mars.Mass = 0.642;
                Mars.Diameter = 6792;
                Mars.Density = 3933;
                Mars.Gravity = 3.7;
                Mars.Rotationperiod = 24.6;
                Mars.Lengthofday = 24.7;
                Mars.Distancefromsun = 227.9;
                Mars.Orbitalperiod = 687.0;
                Mars.Orbitalvelocity = 24.1;
                Mars.Meantemperature = -65;
                Mars.Numberofmoons = 2;
                Mars.Ringsystem = false;
            }

            Planets Jupiter = new Planets();
            {
                Jupiter.Name = "Jupiter";
                Jupiter.Mass = 1898;
                Jupiter.Diameter = 142984;
                Jupiter.Density = 1326;
                Jupiter.Gravity = 23.1;
                Jupiter.Rotationperiod = 9.9;
                Jupiter.Lengthofday = 9.9;
                Jupiter.Distancefromsun = 778.6;
                Jupiter.Orbitalperiod = 4331;
                Jupiter.Orbitalvelocity = 13.1;
                Jupiter.Meantemperature = -110;
                Jupiter.Numberofmoons = 67;
                Jupiter.Ringsystem = true;
            }

            Planets Saturn = new Planets();
            {
                Saturn.Name = "Saturn";
                Saturn.Mass = 568;
                Saturn.Diameter = 120536;
                Saturn.Density = 687;
                Saturn.Gravity = 9.0;
                Saturn.Rotationperiod = 10.7;
                Saturn.Lengthofday = 10.7;
                Saturn.Distancefromsun = 1433.5;
                Saturn.Orbitalperiod = 10747;
                Saturn.Orbitalvelocity = 9.7;
                Saturn.Meantemperature = -140;
                Saturn.Numberofmoons = 62;
                Saturn.Ringsystem = true;
            }

            Planets Uranus = new Planets();
            {
                Uranus.Name = "Uranus";
                Uranus.Mass = 86.8;
                Uranus.Diameter = 51118;
                Uranus.Density = 1271;
                Uranus.Gravity = 8.7;
                Uranus.Rotation_period = -17.2;
                Uranus.Lengthofday = 17.2;
                Uranus.Distancefromsun = 2872.5;
                Uranus.Orbitalperiod = 30589;
                Uranus.Orbitalvelocity = 6.8;
                Uranus.Meantemperature = -195;
                Uranus.Numberofmoons = 27;
                Uranus.Ringsystem = true;
            }

            Planets Neptune = new Planets();
            {
                Neptune.Name = "Neptune";
                Neptune.Mass = 102;
                Neptune.Diameter = 49528;
                Neptune.Density = 1638;
                Neptune.Gravity = 11.0;
                Neptune.Rotationperiod = 16.1;
                Neptune.Lengthofday = 16.1;
                Neptune.Distancefromsun = 4495.1;
                Neptune.Orbitalperiod = 59800;
                Neptune.Orbitalvelocity = 5.4;
                Neptune.Meantemperature = -200;
                Neptune.Numberofmoons = 14;
                Neptune.Ringsystem = true;
            }

           Planets Pluto = new Planets();
            {
                Pluto.Name = "Pluto";
                Pluto.Mass = 0.0146;
                Pluto.Diameter = 2370;
                Pluto.Density = 2095;
                Pluto.Gravity = 0.7;
                Pluto.Rotationperiod = -153.3;
                Pluto.Lengthofday = 153.3;
                Pluto.Distancefromsun = 5906.4;
                Pluto.Orbitalperiod = 90560;
                Pluto.Orbitalvelocity = 4.7;
                Pluto.Meantemperature = -225;
                Pluto.Numberofmoons = 5;
                Pluto.Ringsystem = false;
            }

            List<Planets> Planetlist = new List<Planets>();

            Planetlist.Add(Mercury);
            Planetlist.Add(Earth);
            Planetlist.Add(Mars);
            Planetlist.Add(Jupiter);
            Planetlist.Add(Saturn);
            Planetlist.Add(Uranus);
            Planetlist.Add(Neptune);
            Planetlist.Add(Pluto);

            foreach (Planets Planet in Planetlist)
            {
                Console.WriteLine(Planet.name);
            }
            Console.WriteLine();
            Planetlist.Insert(1, Venus);

            foreach (Planets Planet in Planetlist)
            {
                Console.WriteLine(Planet.name);
            }
            Console.WriteLine();
            Planetlist.Remove(Pluto);

            foreach (Planets Planet in Planetlist)
            {
                Console.WriteLine(Planet.name);
            }
            Console.WriteLine();
            Planetlist.Add(Pluto);

            Console.WriteLine(Planetlist.Count);
            Console.WriteLine();

            List<Planets> Planetsbelowzero = new List<Planets>();

            foreach (Planets planet in Planetlist)
            {
                if (planet.meantempature < 0)
                {
                    Planetsbelowzero.Add(planet);
                }
            }
            foreach (Planets planet in Planetsbelowzero)
            {
                Console.WriteLine(planet.name);
            }
            Console.WriteLine();

            List<Planets> diameterplanets = new List<Planets>();

            Planetlist.Clear();
        }


         }
    }

