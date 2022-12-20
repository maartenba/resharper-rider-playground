using System.Text;

namespace CSharp11;

public static class RawStrings
{
    // [Obsolete("""
    //     It also works in attributes!
    //     """)]
    public static void Start()
    {
        // CA: convert to raw
        var verbatimString = @"{
  ""sdk"": {
        ""allowPrerelease"": true
    }
}";
        
        var simpleRawJson = """{"name":"Lucy","age":43}""".Dump();
        
        // lang=JSON
        var multilineJson = """
            {
                "name": "Lucy",
                "age": 54
            }
            """.Dump(); // <- This denotes the indentation

        // lang=HTML
        var multilineHtml = """
            <html>
            </html>
            """;

        var interpolatedJson = $"""This is a {multilineJson} interpolation!""".Dump();
    }
}
