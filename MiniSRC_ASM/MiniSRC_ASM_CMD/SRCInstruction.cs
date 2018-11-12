using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSRC_ASM_CMD
{
    class SRCInstruction
    {
        public string originalInstructionString { get; set; }
        public string outputInstructionString { get; set; }
        public bool replaceImmediateWithAddress { get; set; }
        public string immediateToReplace { get; set; }
    }
}
