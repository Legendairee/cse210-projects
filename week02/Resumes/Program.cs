using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2022;

        Resume myResume = new Resume();

        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.Display();

    }
}



// Here’s a clear, labeled breakdown of every important C# concept that appears in your program.1. ClassesA class is a blueprint (template) for creating objects.Job → blueprint for a job
// Resume → blueprint for a resume
// Program → the special class that contains the starting point of the program

// csharp

// public class Job { ... }
// public class Resume { ... }
// class Program { ... }

// 2.Member Variables(also called Fields or Attributes)These are the data that each object stores.In the Job class: csharp

// public string _company;      // member variable
// public string _jobTitle;     // member variable
// public int _startYear;       // member variable
// public int _endYear;         // member variable

// In the Resume class: csharp

// public string _name;                    // member variable
// public List<Job> _jobs = new List<Job>(); // member variable (with default value)

// The underscore _ at the beginning is just a common naming convention for private/public fields .3.Creating a New Instance(Object)When you write new, you create a real object from the class blueprint.csharp

// Job job1 = new Job();        // Creates a new Job object
// Job job2 = new Job();        // Creates another new Job object
// Resume myResume = new Resume(); // Creates a new Resume object

// Job job1 → declares a variable that can hold a Job
// = new Job() → actually creates the object in memory

// 4. ConstructorA constructor is a special method that runs automatically when you create an object with new.In your current code, you are using the default constructor(the one C# creates for you automatically because you didn’t write one).csharp

// new Job()          // calls the default constructor of Job
// new Resume()       // calls the default constructor of Resume
// new List<Job>()    // calls the default constructor of List

// You can later write your own constructors if you want.5.Methods(Actions / Behaviors)A method is a block of code that performs an action.csharp

// public void Display()   // This is a method
// {
//     Console.WriteLine(...);
// }

// You have three methods in total:Job.Display()
// Resume.Display()
// Program.Main()(the special starting method)

// 6.Calling a MethodTo use a method, you call it using the object + dot + method name.csharp

// job1.Display();           // Calling the Display method on job1
// myResume.Display();       // Calling the Display method on myResume

// 7.Setting Member Variables(Assigning values)You access a member variable with the object + dot + variable name:csharp

// job1._jobTitle = "Software Engineer";
// job1._company = "Microsoft";
// myResume._name = "Allison Rose";

// 8.Adding to a Listcsharp

// myResume._jobs.Add(job1);   // Adds job1 into the list that belongs to myResume
// myResume._jobs.Add(job2);

// _jobs is a List < Job >, so it has an .Add() method.9. The foreach LoopThis is used inside Resume.Display() to go through every job in the list:csharp

// foreach (Job job in _jobs)
// {
//     job.Display();   // Call Display on each job
// }

// Full Flow of Your Program (in order)Create job1 → set its 4 member variables  
// Create job2 → set its 4 member variables  
// Create myResume → set its _name  
// Add both jobs into myResume._jobs list  
// Call myResume.Display()  It prints the name  
// Then loops through the list and calls job.Display() on each job

// Quick Vocabulary SummaryConcept
// Example in your code
// What it means
// Class
// class Job, class Resume
// Blueprint
// Member variable / Field
// _jobTitle, _name, _jobs
// Data stored in the object
// Object / Instance
// job1, job2, myResume
// Real thing created from the class
// Constructor
// new Job()
// Code that runs when object is created
// Method
// Display()
// Action the object can perform
// Method Call
// job1.Display()
// Telling the object to perform the action
// List
// List<Job> _jobs
// Collection that can hold many objects
