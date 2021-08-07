using System;

namespace LinqStudentApp.Model
{
    public class Student
    {
        private String _name, _location;
        private float _cgpa;

        public Student(String name, String location, float cgpa)
        {
            _name = name;
            _location = location;
            _cgpa = cgpa;
        }

        public String Name
        {
            get { return _name; }
        }
        public String Location
        {
            get { return _location; }
        }
        public float Cgpa
        {
            get { return _cgpa; }
        }
    }
}
