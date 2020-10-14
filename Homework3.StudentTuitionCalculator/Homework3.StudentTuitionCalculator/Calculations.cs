//Christine Jordan 10.13.2020
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework3.StudentTuitionCalculator
{
    public class Calculations : CollectionBase
    {
        public void Add(string studentID, int numCredit, ResidentStatuses statuses)
        {
            Calculator calculator = new Calculator(studentID, numCredit, statuses);//instantiation calls constructor
            List.Add(calculator);//List comes from the parent (CollectionBase)
        }

        public void Add(Calculator calculator)
        {
            List.Add(calculator); //adding calculator to the list
        }

        public Calculator this[int index] //indexer
        {
            get { return (Calculator)List[index]; }//casting the object found in list at location index
            set
            {
                List[index] = value; //value going into indexed spot in list
            }
        } 


       
    }
}
