using System;
using System.Collections.Generic;

namespace JobPortalScreeningSystem
{
    // Candidate Model (OOP: Encapsulation)
    public class Candidate
    {
        public string Name { get; set; }
        public string PrimarySkill { get; set; }
        public int YearsOfExperience { get; set; }
        public double CGPA { get; set; }

        public Candidate(string name, string skill, int experience, double cgpa)
        {
            Name = name;
            PrimarySkill = skill.ToLower();
            YearsOfExperience = experience;
            CGPA = cgpa;
        }

        public void DisplayCandidateInfo()
        {
            Console.WriteLine($"Name: {Name} | Skill: {PrimarySkill.ToUpper()} | Exp: {YearsOfExperience} Years | CGPA: {CGPA}");
        }
    }

    class Program
    {
        // Global List to act as our Database in memory
        static List<Candidate> candidatePool = new List<Candidate>();

        static void Main(string[] args)
        {
            // Seeding dummy data initially so the portal is not empty
            candidatePool.Add(new Candidate("Ahmed Muhammad", "C#", 1, 3.1));
            candidatePool.Add(new Candidate("Zubair Khan", "Python", 3, 3.5));
            candidatePool.Add(new Candidate("Sara Ali", "C#", 0, 3.9));
            candidatePool.Add(new Candidate("Hamza Sheikh", "JavaScript", 2, 2.8));

            bool running = true;

            // Loop: Main Application Loop
            while (running)
            {
                Console.WriteLine("\n=============================================");
                Console.WriteLine("    WELCOME TO TECH-HIRE SCREENING SYSTEM    ");
                Console.WriteLine("=============================================");
                Console.WriteLine("1. Register a New Candidate (Input)");
                Console.WriteLine("2. View All Applicants");
                Console.WriteLine("3. Filter Candidates by Tech Skill (DSA: Filtering)");
                Console.WriteLine("4. Sort Candidates by Merit/CGPA (DSA: Bubble Sort)");
                Console.WriteLine("5. Exit Application");
                Console.Write("\nSelect an option (1-5): ");

                string choice = Console.ReadLine();

                // Conditionals: Option Tracking
                if (choice == "1")
                {
                    RegisterCandidate();
                }
                else if (choice == "2")
                {
                    ViewAllCandidates();
                }
                else if (choice == "3")
                {
                    FilterBySkill();
                }
                else if (choice == "4")
                {
                    SortCandidatesByCGPA();
                }
                else if (choice == "5")
                {
                    running = false;
                    Console.WriteLine("\nExiting System... Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid Choice! Please enter a number between 1 and 5.");
                }
            }
        }

        // Feature 1: Dynamic User Input
        static void RegisterCandidate()
        {
            Console.WriteLine("\n--- Candidate Registration Portal ---");
            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Primary Technical Skill (e.g., C#, Python, JavaScript): ");
            string skill = Console.ReadLine();

            Console.Write("Enter Years of Practical Experience: ");
            int exp = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Current/Final CGPA (e.g., 3.1): ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            // Creating Object and storing it
            candidatePool.Add(new Candidate(name, skill, exp, cgpa));
            Console.WriteLine($"\nSuccess: {name} has been successfully added to the recruitment pipeline!");
        }

        // Feature 2: Display Data
        static void ViewAllCandidates()
        {
            Console.WriteLine("\n--- Current Applicant Pool ---");
            if (candidatePool.Count == 0)
            {
                Console.WriteLine("No candidates registered yet.");
                return;
            }

            foreach (var candidate in candidatePool)
            {
                candidate.DisplayCandidateInfo();
            }
        }

        // Feature 3: DSA Logic - Filtering Algorithms
        static void FilterBySkill()
        {
            Console.WriteLine("\n--- Skill Filtering Engine ---");
            Console.Write("Enter required skill to search: ");
            string searchSkill = Console.ReadLine().ToLower();

            Console.WriteLine($"\nSearch Results for '{searchSkill.ToUpper()}':");
            bool found = false;

            // Algorithm: Linear Search / Filter Mechanism
            for (int i = 0; i < candidatePool.Count; i++)
            {
                if (candidatePool[i].PrimarySkill == searchSkill)
                {
                    candidatePool[i].DisplayCandidateInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No candidates found with this specific skill set.");
            }
        }

        // Feature 4: DSA Logic - Sorting Algorithm (In-Place Bubble Sort)
        static void SortCandidatesByCGPA()
        {
            Console.WriteLine("\n--- Sorting System (Merit Rank by CGPA) ---");

            if (candidatePool.Count < 2)
            {
                Console.WriteLine("Not enough candidates to perform sorting metrics.");
                return;
            }

            // Creating a deep copy list to avoid ruining the original insertion order
            List<Candidate> sortedList = new List<Candidate>(candidatePool);

            // DSA Core: Bubble Sort Algorithm (Descending Order)
            int n = sortedList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedList[j].CGPA < sortedList[j + 1].CGPA)
                    {
                        // Swap logic
                        Candidate temp = sortedList[j];
                        sortedList[j] = sortedList[j + 1];
                        sortedList[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nRanked Applicants (Highest CGPA first):");
            int rank = 1;
            foreach (var candidate in sortedList)
            {
                Console.Write($"Rank #{rank} -> ");
                candidate.DisplayCandidateInfo();
                rank++;
            }
        }
    }
}
