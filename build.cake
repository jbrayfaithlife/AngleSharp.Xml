var target = Argument("target", "Default");
var projectName = "AngleSharp.Xml";
var solutionName = "AngleSharp.Xml";
var frameworks = new Dictionary<String, String>
{
    { "net46", "net46" },
    { "net461", "net461" },
    { "net472", "net472" },
    { "netstandard2.0", "netstandard2.0" },
};

#load tools/anglesharp.cake

RunTarget(target);
