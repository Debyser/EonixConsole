using System.ComponentModel;

namespace EonixConsole
{
    public enum Trick
    {
        None = 0,
        [Description("Magie")]
        Magic = 1,
        [Description("Acrobatie")]
        Acrobatics = 2,
    }
}
