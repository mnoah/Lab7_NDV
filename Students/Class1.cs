using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Classroom
    {
        
            private Student[] m_Student = new Student[20];
            public Classroom()
            {
                for (int i = 0; i < m_Student.Length; i++)
                {
                    m_Student[i] = new Student();
                }
                m_Student[19].Name = "Kim";
                m_Student[19].HomeTown = "Detroit";
                m_Student[19].FavFood = "Cake";
                m_Student[19].Gender = "F";

            }
        }
}
