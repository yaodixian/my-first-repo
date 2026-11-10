using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo0529
{
    public abstract class abstract_Demo
    {
        public abstract void Eat();
        public abstract void Walk();
    }
    public class abstarct_Child : abstract_Demo
    {
        /// <summary>
        /// this remark
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Eat() 
        {
            throw new NotImplementedException();
        }
        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
