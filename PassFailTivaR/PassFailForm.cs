﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassFailTivaR
{
    public partial class frmPassFail : Form
    {
        // Input and Output
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output.txt";

        // Declare local variables
        float weightTests, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markQuizzes;
        int numStudents;
        float average;
        int numPassed = 0;
        int counterA, counterB;

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
                    string line = lines[counterA];

                    // Split each weight by the space delimeter
                    string[] weights = line.Split(' ');

                    // Get the weight for the tests, assignments, projects and quizzes
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    // For testing purposes only, write the weights to the output file
                    file.WriteLine("Weights " + weightTests + " " + weightAssign + " " + weightProjects + " " + weightQuizzes);

                    // Get num Students from the lines array. (It will be at the following index)
                    /////// I'm not sure if this code is correct
                    int numStudents = line[counterB];

                    // Then Output it to the output file for testing
                    file.WriteLine("Number of students" + numStudents);

                   /* // Loop through each student
                    for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++)
                    {
                        // Split each student's marks into an array of strings called studentMarks[]

                    }
                    */

                }
            }

        }
    }
}