﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation.Client
{
    class CannonMG2470 : IFaxContent , IPrintScanContent
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
