﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventyrspil_3._0
{
    class Key
    {        
        public int KeyId { get; set; }

        public override string ToString()
        {
            return "KeyID: " + KeyId;
        }
    }
}
