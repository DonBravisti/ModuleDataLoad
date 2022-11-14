using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleEditorClassLibrary
{
    public class ListGroups
    {
        List<Group> groups;

        public List<Group> Groups
        {
            get;
            set;
        }
    }

    public class Group
    {
        List<AcademicClass> classes; // ScheduleAcademicClass
    }

    public enum ClassType
    {
        Lecture,
        Practice
    }

    public enum SubGroup
    {
        first,
        second
    }

    public class AcademicClass
    {
        string classTitle;
        Teacher teacher;
        int hours;
        ClassType type;
        SubGroup subGroup;

        public AcademicClass() { }

        public SubGroup SubGroup
        {
            get => default;
            set
            {
            }
        }

        public ClassType ClassType
        {
            get => default;
            set
            {
            }
        }

        public Teacher Teacher
        {
            get => default;
            set
            {
            }
        }
    }

    public enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class ScheduleAcademicClass : AcademicClass
    {
        int Audience;
        WeekDay weekDay;
        int ClassNumber;

        public ScheduleAcademicClass() : base()
        {

        }

        public WeekDay WeekDay
        {
            get => default;
            set
            {
            }
        }
    }

    public class Teacher
    {
        string name;
    }
}