using System.Globalization;
using System.Text.Json;

namespace Exsited.Client;

// Rendering rules shared by every display path, so none spells a value differently.
internal static class Display
{
    // Invariant, and always with a decimal point, so a whole second reads 1.0s.
    internal static string Seconds(double elapsed) =>
        elapsed.ToString("0.0###", CultureInfo.InvariantCulture);

    // Derived from Redaction.DisplayJson, so display paths cannot drift apart.
    internal static readonly JsonSerializerOptions Json = new(Redaction.DisplayJson);
}
