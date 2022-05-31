using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Student
    {
        /// <summary>
        /// 학생 이름
        /// </summary>
        public string name;
        /// <summary>
        /// 학생 성적
        /// </summary>
        public int grade;

        /// <summary>
        /// 학생 객체 문자열 출력
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }
    }
}
