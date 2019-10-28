using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenebStudio
{
    public class TemplateGeneration
    {
        public string Path { get; set; }
        public string ProjectName { get; set; }

        const string CONSOLE_FULL_GITIGNORE = "# Files and directories created by Dart Studio\n.dart_tool/\n.packages\n# Remove the following pattern if " +
            "you wish to check in your lock file\npubspec.lock\n\n# Conventional directory for build outputs\nbuild/\n\n# Directory created by dartdoc\n" +
            "doc/api/";

        const string CONSOLE_FULL_ANALYSIS_OPTIONS = "# Defines a default set of lint rules enforced for\n# projects at Google. For details and rationale,\n" +
            "# see https://github/dart-lang/pedantic#enable-lints. \ninclude: package:pedantic/analysis_options.yaml\n\n# For limit rules and documentation," +
            " see https://dart-lang.github.io/linter/lints. \n# Uncomment to specify additional rules.\n# linter:\n#   rules:\n#     - camel_case_types\n\n" +
            "analyzer:\n# exclude:\n#   - path/to/excluded/files/**";

        const string CONSOLE_FULL_CHANGELOG = "#1.0.0\n\n- First version, created by Deneb Studio";

        const string CONSOLE_FULL_PUBSPEC = "name: ProjectName\ndescription: A Basic Dart Console-Full Application created with Deneb Studio.\nversion: 1.0.0" +
            "\n# homepage: https://www.example.com\n# author: Author Name <authorname@gmail.com>\n\nenvironment:\n  sdk: '>=2.5.0 <3.0.0'\n\n" +
            "#dependencies:\n#   path: ^1.6.0\n\ndev_dependencies:\n  pedantic: ^1.8.0\n  test: ^1.6.0";

        const string CONSOLE_FULL_README = "# ProjectName\n\nThis is a simple Dart Console-Full Application created in Deneb Studio\n\nTo learn more about " +
            "Deneb Studio to increase your projects production, please log into the follow\n[link] (https://github.com/cygnus-project/DenebStudio)\n\n" +
            "To read the license, please log into the follow link\n[license] (https://github.com/cygnus-project/DenebStudio/blob/master/LICENSE.md)";

        const string CONSOLE_FULL_LIB = "int basicMathOperation(){\n    return 5 * 5;\n}";

        

        public void GenerateProject(ProjectType projectType)
        {
            string CONSOLE_FULL_BIN = "import 'package:" + ProjectName +
                "/'" + ProjectName + ".dart'"+ " as project_name;\nvoid main(){\n  print(\"Hello World!\r\nIntroducing Dart " +
            "with Deneb Studio\\r\\nHere is a Basic Math Operation: ${" + ProjectName + ".basicMathOperation()}\");\n}";

            if (projectType == ProjectType.ConsoleFull)
            {
                GenerateFile(".gitignore", CONSOLE_FULL_GITIGNORE);
                GenerateFile("analysis_options.yaml", CONSOLE_FULL_ANALYSIS_OPTIONS);
                GenerateFile("CHANGELOG.md", CONSOLE_FULL_CHANGELOG);
                GenerateFile("pubspec.yaml", CONSOLE_FULL_PUBSPEC);
                GenerateFile("README.md", CONSOLE_FULL_README);
                GenerateFile($"lib\\{ProjectName}.dart", CONSOLE_FULL_LIB);
                GenerateFile("bin\\main.dart", CONSOLE_FULL_BIN);
            }
        }

        private void GenerateFile(string file, string content)
        {
            if (!File.Exists($"{Path}\\{ProjectName}\\{file}"))
            {
                // Create a file to write to.

                File.WriteAllText($"{Path}\\{ProjectName}\\{file}", content);
            }
        }

    }

    public enum ProjectType
    {
        ConsoleFull = 0,
        FlutterApp = 1
    }
}
