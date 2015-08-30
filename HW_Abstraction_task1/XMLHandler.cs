using System;

namespace HW_Abstraction_task1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("This file is .xml file. It is opened now");
        }

        public override void Create()
        {
            Console.WriteLine("This file is .xml file. It is created now");
        }

        public override void Change()
        {
            Console.WriteLine("This file is .xml file. It is changed now");
        }

        public override void Save()
        {
            Console.WriteLine("This file is .xml file. It is saved now");
        }
    }
}
