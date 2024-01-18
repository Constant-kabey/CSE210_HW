using System. Text;
using System. Threading. Tasks;

namespace Project
{
    public class Job
    {
        public string _jobtittle;
        public string _company;
        public int _startdate;
        public int _enddate;

        public void Display()
        {
            Console.WriteLine($"{_jobtittle} ({_company}) {_startdate}-{_enddate} ");
        }
    }
}