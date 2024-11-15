using System;

class Program
{
    static void Main(string[] args)
    {
        // Do an instance and use Job and Resume classes here
        // Keeping the classes or user datatypes that we create in different files, the code becomes more readable and easier to go through.
        // Why do we not need to use 
        Job job1 = new Job();
        job1._jobTitle = "Graphic Designer";
        job1._company = "Canva";
        job1._startYear = 2025;
        job1._endYear = 2028;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Salesman";
        job2._company = "McDonald's";
        job2._startYear = 2024;
        job2._endYear = 2027; //2024 Tested with different text to verify it works.
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Isabela Paz Soldan";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}

// I was on a time crunch so I did use AI to help build the code, but I did research it and understand how the code works. 


// Personal notes: 

// Classes are kind of like data types but created by users, similar to how you can define 
// functions that are not already included in libraries using lambda. Very interesting. 
// It is similar to always puting the data type first in C#, but in this case I put Resume myResume = new Resume();
