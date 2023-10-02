﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using CppAst;

namespace Generator;

public static class Program
{
    public static int Main(string[] args)
    {
        string outputPath = AppContext.BaseDirectory;
        if (args.Length > 0)
        {
            outputPath = args[0];
        }

        if (!Path.IsPathRooted(outputPath))
        {
            outputPath = Path.Combine(AppContext.BaseDirectory, outputPath);
        }

        if (!outputPath.EndsWith("Generated"))
        {
            outputPath = Path.Combine(outputPath, "Generated");
        }

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        CsCodeGeneratorOptions generateOptions = new()
        {
            OutputPath = outputPath,
            ClassName = "SDL",
            Namespace = "SDL",
            PublicVisiblity = true,
            GenerateFunctionPointers = false,
            EnumWriteUnmanagedTag = true
        };

        string[] headers =
        [
            "SDL_clipboard.h",
            "SDL_scancode.h",
            "SDL_keycode.h",
            //"SDL_video.h",
        ];

        foreach(string header in headers)
        {

            string? headerFile = Path.Combine(AppContext.BaseDirectory, "include", $"SDL3/{header}");
            var options = new CppParserOptions
            {
                ParseMacros = true,
                SystemIncludeFolders =
                {
                    Path.Combine(AppContext.BaseDirectory, "include")
                }
            };

            CppCompilation compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (CppDiagnosticMessage message in compilation.Diagnostics.Messages)
                {
                    if (message.Type == CppLogMessageType.Error)
                    {
                        var currentColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(message);
                        Console.ForegroundColor = currentColor;
                    }
                }

                return 0;
            }

            CsCodeGenerator.Collect(compilation);
            CsCodeGenerator.Generate(compilation, generateOptions);
        }

        return 0;
    }
}
