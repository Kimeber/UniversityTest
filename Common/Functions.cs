using DataLayer;
using System;
using System.Collections.Generic;
using ViewModels;

namespace Common
{
    public class Functions
    {
        public static decimal CalculateGrade(List<ClassStudent> classStudent)
        {
            decimal value = 0;
            if(classStudent.Count > 0)
            {
                foreach (var st in classStudent)
                {
                    value += st.Grade ?? 0;
                }
                value /= classStudent.Count;
            }
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }

        public static decimal CalculateAverage(List<ClassStudentViewModel> list)
        {
            decimal value = 0;
            if (list.Count > 0)
            {
                foreach (var st in list)
                {
                    value += st.Grade ?? 0;
                }
                value /= list.Count;
            }
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }

        public static decimal CalculateAverage(List<ClassStudent> list)
        {
            decimal value = 0;
            if (list.Count > 0)
            {
                foreach (var st in list)
                {
                    value += st.Grade ?? 0;
                }
                value /= list.Count;
            }
            return Math.Round(value, 2, MidpointRounding.ToEven);
        }
    }
}
