using System;
using System.Collections.Generic;
using System.Text;

namespace builder_pattern_test
{
    public class ReadOnlyTest
    {
        public readonly Person _person;
        
        public ReadOnlyTest()
        {
            this._person = new Person();
        }

    }
}
