using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    /*
        1. No client should be forced to depend on methods it does not use.
        2. One fat interface need to be split to many small & relevant interfaces so that client can know about the interface that can relevant to them.
     
     */
     interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplex(string content);
    }
}
