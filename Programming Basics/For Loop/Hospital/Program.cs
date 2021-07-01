using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= n; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && treatedPatients < untreatedPatients)
                {
                    doctors++;
                }
                if (doctors == patients)
                {
                    treatedPatients += doctors;
                }
                else if (doctors > patients)
                {
                    treatedPatients += patients;
                }
                else if (doctors < patients)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
