using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTen.Services
{
    public class Magic8BallServices
    {
        string[] Respownses = {
    "Indeed","Maybe", "Yes","No", "Theres a high chance","Im not sure","Hard to say", "Most likley not", "I dont have all the answers"};

        public string Answers(string input)
        {
            
            Random random = new Random();
            int answers = random.Next(Respownses.Length);
            return Respownses[answers];
        }

    }
}