using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bakkerij.Enum
{
    public enum FunctieOmschrijving
    {
        [Description("Inkoper")]Inkoper,
        [Description("Verkoper")]Verkoper,
        [Description("Manager")]Manager
    }
}
