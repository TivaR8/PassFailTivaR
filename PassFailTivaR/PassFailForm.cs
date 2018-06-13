using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 13-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - PassFail
 * This program allows you to give it an input file with data and you can then...
 * ...use the program to have an output file created with the answers to the...
 * ...calculations. This program in particular takes the scores of students in...
 * ...a class and then tells you how many students in each year passed depending...
 * ...on their marks and how important each grade is.
*/

namespace PassFailTivaR
{
    public partial class frmPassFail : Form
    {
        // Input and Output
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output.txt";

        // Declare local variables
        float weightTests, weightAssign, weightProjects, weightQuizzes = 0;
        float markTests, markAssign, markProjects, markQuizzes = 0;
        int numStudents;
        float average;
        int numPassed = 0;
        int counterA = 0;
        int counterB = 0;
        string line;
        
        

        public frmPassFail()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each...
            //... element of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(filepath);

            // loop through each line of the array oflinew
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile))
            {
                // Loop through each line of the array
                for (counterA = 0; counterA < lines.Length; counterA++)
                {
                    // Initialize number of students who got >= 50%
                    numPassed = 0;

                    // Read the first line for the next set of students
                    line = lines[counterA];

                    // Testing purposes
                    //Console.WriteLine("*** lines = " + lines[counterA + 1]);
            

                    // Split each weight by the space delimeter
                    string[] weights = line.Split(' ');

                    // Testing purposes
                    /*
                    Console.WriteLine("*** weights[0] = " + weights[0]);
                    Console.WriteLine("*** weights[1] = " + weights[1]);
                    Console.WriteLine("*** weights[2] = " + weights[2]);
                    Console.WriteLine("*** weights[3] = " + weights[3]);
                    */

                    // Get the weight for the tests, assignments, projects and quizzes
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    // For testing purposes only
                    //Console.WriteLine("Weights " + weightTests + " " + weightAssign + " " + weightProjects + " " + weightQuizzes);

                    // Get num Students from the lines array. (It will be at the following index)
                    //To find how many students there are
                    numStudents = int.Parse(lines[counterA + 1]);

                    // Testing purposes
                    //Console.WriteLine("Number of students " + numStudents);


                

                    // Loop through each student
                    for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++)
                    {
                        // Read the first line for the next set of students
                        line = lines[counterB];

                        // Testing purposes
                        //Console.WriteLine("***lines[counterB] = " + lines[counterB]);

                        // Split each student's marks into an array of strings called studentMarks[]
                        string[] studentMarks = line.Split(' ');

                        markTests = float.Parse(studentMarks[0]);
                        markAssign = float.Parse(studentMarks[1]);
                        markProjects = float.Parse(studentMarks[2]);
                        markQuizzes = float.Parse(studentMarks[3]);

                        // For testing purposes only write the student's average to the output file
                        //file.WriteLine("studentMarks " + markTests + " " + markAssign + " " + markProjects + " " + markQuizzes);

                        // Calculate the average for the student
                        average = ((weightTests * (markTests / 100)) + (weightAssign * (markAssign / 100)) + (weightProjects * (markProjects / 100)) + (weightQuizzes * (markQuizzes / 100)));

                        // For testing purposes only, write it to the output file
                        //file.WriteLine("average " + average);

                        // If average is over 50, increment the number of students who passed
                        if (average >= 50)
                        {
                            numPassed = numPassed + 1;
                        }
                    }

                    // For testing purposes, write the number ofstudents who passed to the console file
                    //Console.WriteLine("numPassed " + numPassed);

                    // Output to the file the numberof students that have passed
                    file.WriteLine(numPassed);

                    // reset the initial counter to start at the next batch of students
                    counterA = counterB - 1;

                }

    
            }

        }
    }
}
