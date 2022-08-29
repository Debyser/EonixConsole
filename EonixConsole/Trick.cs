using System.ComponentModel;

namespace EonixConsole
{
    public enum Trick
    {
        None = 0,
        [Description("Musique")]
        Music = 1,
        [Description("Acrobatie")]
        Acrobatics = 2,
    }
}
