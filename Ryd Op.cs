using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace WMIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDiskMetadata();
            GetHardDiskSerialNumber();

            MOS searcher = new MOS("select * from Win32_PerfFormattedData_PerfOS_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                string usage = obj["PPT"];
                string name = obj["Name"];
                Console.WriteLine(name + " : " + usage);
                Console.WriteLine("CPU");
            }

            hovedLager();
            test();
            testhest();

            Console.WriteLine("process søgning");
            LISTAllServices();





            Console.ReadKey();

        } //Slut main

       static void test()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            MOS searcher = new MOS(wql);
            MOC results = searcher.Get();
            foreach (ManagementObject result in results)
            {
                Console.WriteLine("User:\t{0}", result["RegisteredUser"]);
                Console.WriteLine("Org.:\t{0}", result["Organization"]);
                Console.WriteLine("O/S :\t{0}", result["Name"]);
            }

        }

        static void testhest()
        {
            Console.WriteLine("test start");
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\cimv2d);

            //create object query
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");

            //create object searcher
            MOS searcher = new MOS(scope, query);

            //get a collection of WMI objects
            MOC queryCollection = searcher.Get();

            //enumerate the collection.
            foreach (ManagementObject in queryCollection)
            {
                // access properties of the WMI object
                Console.WriteLine("BootDevice : {0}", ["BootDevice"]);
            }
            Console.WriteLine("test slut");


        }
        static List<string> PopulateDisk()

        {
            List<string> disk = new List<string>();
            SelectQuery selectQuery = new SelectQuery("Win32_LogicalDisk");
            ManagementObjectSearcher MOS = new MOC(selectQuery);

            foreach (ManagementObject managementObject in ManagementObjectSearcher()) 
            {
                disk.Add(managementObject.ToString());
            }

            return disk;

        }

        static void hovedLager()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            MOS searcher = new MOSl(wql);
            MOC results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                Console.WriteLine("Total Visible Memory: {0}KB", result["TotalVisibleMemorySize"]);
                Console.WriteLine("Free Physical Memory: {0}KB", result["FreePhysicalMemory"]);
                Console.WriteLine("Total Virtual Memory: {0}KB", result["TotalVirtualMemorySize"]);
                Console.WriteLine("Free Virtual Memory: {0}KB", result["FreeVirtualMemory"]);
            }

        }


        static void GetDiskMetadata()
        {
            SystemManagementScope managementScope = new SystemManagementScope();
            SystemManagement objectQuery = new SystemManagement("select FreeSpace,Size,Name from Win32_LogicalDisk where DriveType=3");
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(managementScope, objectQuery);
            ManagementObjectCollection MOC = managementObjectSearcher.Get(); 
           
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                Console.WriteLine("Disk Name : " + managementObject["Name"].ToString());
                Console.WriteLine("FreeSpace: " + managementObject["FreeSpace"].ToString());
                Console.WriteLine("Disk Size: " + managementObject["Size"].ToString());
                Console.WriteLine("---------------------------------------------------");
            }
            
        }

        static string GetHardDiskSerialNumber()
            
        {
            string drive = "C"
            ManagementObject managementObject = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + drive + ":\"");
            managementObject.Get(); 
            Console.WriteLine(managementObject["VolumeSerialNumber"].ToString());
            return managementObject["VolumeSerialNumber"].ToString();
        }
        
        private static void LISTAllServices()
        {
            ManagementObjectSearcher WWS = new ManagementObjectSearcher("root\\cimv2", "select * from Win32_Service");
            ManagementObjectCollection objectCollection = WWS.Get();

            Console.WriteLine("There are {0} Windows services: ", objectCollection.Count);
            
            foreach (ManagementObject windowsService in objectCollection) 
            {
                PropertyDataCollection serviceProperties = windowsService.Properties;
                foreach (PropertyData serviceProperty in serviceProperties) 
                {
                    if (serviceProperty.Value != null)
                    {
                        Console.WriteLine("Windows service property name: {0}", serviceProperty.Name);
                        Console.WriteLine("Windows service property value: {0}", serviceProperty.Value);
                    }
                }
                Console.WriteLine("---------------------------------------");
            }
        }
    }

}
